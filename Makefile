SHELL := bash
ifeq ($(OS),)
OS := $(shell uname -s)
endif

.DEFAULT_GOAL := build
.DELETE_ON_ERROR:
.SHELLFLAGS := -eu -o pipefail -c

MAKEFLAGS += --no-builtin-rules
MAKEFLAGS += --warn-undefined-variables

DOTNET ?= dotnet
SED ?= sed

.PHONY: help
help:
	@$(SED) -e "/^[a-zA-Z0-9_\-]*:.*##/!d" -e "s/:.*##\s*/:/" ${MAKEFILE_LIST} | sort | column -c 2 -s : -t

CONFIGURATION ?= Debug

BUILD := $(DOTNET) build --nologo --no-restore -c ${CONFIGURATION}
RESTORE := $(DOTNET) restore --nologo

build_dir := build
framework := $(shell $(SED) -nr "s|^[[:blank:]]*<TargetFramework>(.*)</TargetFramework>[[:blank:]]*$$|\1|p" Shippo/Shippo.csproj)

cs_files := $(shell find . -name "*.cs" -not -path "*/obj/*")
csproj_files := $(wildcard */*.csproj)
dll := Shippo/bin/${CONFIGURATION}/${framework}/Shippo.dll
packages_lock_files := $(wildcard */packages.lock.json)
project_assets_files := Shippo/obj/project.assets.json
source_files := \
	${cs_files} \
	${csproj_files} \
	global.json \
	Shippo.sln


${packages_lock_files}: ${csproj_files}
	$(RESTORE) --use-lock-file
	@touch -c ${packages_lock_files}

${project_assets_files}: ${csproj_files} ${packages_lock_files}
	$(RESTORE) --locked-mode
	@touch -c ${project_assets_files}

${dll}: ${packages_lock_files} ${project_assets_files} ${source_files}
	$(BUILD)
	@touch -c ${dll}


.PHONY: build
build: ${dll} ## build the library dll (default)

.PHONY: clean
clean: ## remove all build artifacts and temp directories/files
	rm -fr Shippo/bin Shippo/obj
	rm -fr .speakeasy/temp
	rm -fr ${build_dir}

.PHONY: update-lock-files
update-lock-files: ${packages_lock_files} ## update lock files


api_spec := ${build_dir}/public-api.yaml

.PHONY: api-spec
api-spec: ${api_spec} ## download the public api spec

${api_spec}:
	@mkdir -p $(@D)
	curl -s https://docs.goshippo.com/spec/shippoapi/$(notdir ${api_spec}) > ${api_spec}


ifeq (${OS},Linux)
.PHONY: speakeasy-install
speakeasy-install: ## install speakeasy
	curl -fsSL https://raw.githubusercontent.com/speakeasy-api/speakeasy/main/install.sh | sh

else ifeq ($(OS),Darwin)
.PHONY: dotnet-install
dotnet-install: ## install dotnet
	brew install dotnet@6

.PHONY: speakeasy-install
speakeasy-install:
	brew install speakeasy-api/homebrew-tap/speakeasy
endif

.PHONY: speakeasy-auth
speakeasy-auth: ## authenticates the CLI for use with the Speakeasy Platform
	speakeasy auth login

.PHONY: speakeasy-generate-sdk
speakeasy-generate-sdk: ${api_spec} ## regenerate client SDK package
	SPEAKEASY_FORCE_GENERATION=true \
	speakeasy generate sdk \
		-l csharp \
		-s ${api_spec} \
		-o .

.PHONY: speakeasy-run
speakeasy-run: ## run the workflow(s) defined in your `.speakeasy/workflow.yaml` file
	speakeasy run
