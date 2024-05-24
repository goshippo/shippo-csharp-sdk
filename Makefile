LOCAL_SPEC_FILE=./build/public-api.yaml

ifeq ($(OS),)
	OS := $(shell uname -s)
endif

ifeq ($(OS),Linux)
speakeasy-install: # dev task, locally install the speakeasy CLI
	curl -fsSL https://raw.githubusercontent.com/speakeasy-api/speakeasy/main/install.sh | sh

else ifeq ($(OS),Darwin)
dotnet-install: # dev task
	brew install dotnet@6

speakeasy-install: # dev task, locally install the speakeasy CLI
	brew install speakeasy-api/homebrew-tap/speakeasy
endif

speakeasy-auth: # dev task
	speakeasy auth login

clean: # dev task
	rm -fr Shippo/bin Shippo/obj
	rm -fr ShippoTests/bin ShippoTests/obj ShippoTests/TestResults
	rm -fr .speakeasy/temp
	rm -fr build

.PHONY: build
build: # dev task
	dotnet build

test: # dev task
	dotnet test

download-public-spec: # dev task, download the current public spec, in preparation for modifying and running speakeasy-generate
	@mkdir -p build
	curl -s https://docs.goshippo.com/spec/shippoapi/public-api.yaml > ${LOCAL_SPEC_FILE}

speakeasy-generate: # dev task, run the generator on a local spec.  useful for testing out changes to the spec or gen.yaml - but DO NOT commit the results of manual generation
	if [[ ! -f "${LOCAL_SPEC_FILE}" ]]; then \
	  echo "Error: The file '${LOCAL_SPEC_FILE}' does not exist, have you run 'make download-public-spec'?"; \
	  exit 1; \
	fi
	SPEAKEASY_FORCE_GENERATION=true \
	speakeasy generate sdk -l csharp -s ${LOCAL_SPEC_FILE} -o .

speakeasy-run: # dev task, locally run the complete speakeasy workflow.  useful if the generator workflow ever fails, to replicate locally
	speakeasy run
