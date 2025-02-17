//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Shippo.Models.Components;
    using Shippo.Models.Requests;
    using Shippo.Utils;
    
    public class RegisterCarrierAccountRequest
    {

        /// <summary>
        /// The body of the request.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public RegisterCarrierAccountRequestBody RequestBody { get; set; } = default!;

        public CarrierAccountCanadaPostCreateRequest? GetRequestBodyCanadaPost()
        {
            return RequestBody.CarrierAccountCanadaPostCreateRequest;
        }

        public CarrierAccountChronopostCreateRequest? GetRequestBodyChronopost()
        {
            return RequestBody.CarrierAccountChronopostCreateRequest;
        }

        public CarrierAccountColissimoCreateRequest? GetRequestBodyColissimo()
        {
            return RequestBody.CarrierAccountColissimoCreateRequest;
        }

        public CarrierAccountCorreosCreateRequest? GetRequestBodyCorreos()
        {
            return RequestBody.CarrierAccountCorreosCreateRequest;
        }

        public CarrierAccountDeutschePostCreateRequest? GetRequestBodyDeutschePost()
        {
            return RequestBody.CarrierAccountDeutschePostCreateRequest;
        }

        public CarrierAccountDHLExpressCreateRequest? GetRequestBodyDhlExpress()
        {
            return RequestBody.CarrierAccountDHLExpressCreateRequest;
        }

        public CarrierAccountDpdDeCreateRequest? GetRequestBodyDpdDe()
        {
            return RequestBody.CarrierAccountDpdDeCreateRequest;
        }

        public CarrierAccountDPDUKCreateRequest? GetRequestBodyDpdUk()
        {
            return RequestBody.CarrierAccountDPDUKCreateRequest;
        }

        public CarrierAccountFedExCreateRequest? GetRequestBodyFedex()
        {
            return RequestBody.CarrierAccountFedExCreateRequest;
        }

        public CarrierAccountHermesUKCreateRequest? GetRequestBodyHermesUk()
        {
            return RequestBody.CarrierAccountHermesUKCreateRequest;
        }

        public CarrierAccountMondialRelayCreateRequest? GetRequestBodyMondialRelay()
        {
            return RequestBody.CarrierAccountMondialRelayCreateRequest;
        }

        public CarrierAccountPosteItalianeCreateRequest? GetRequestBodyPosteItaliane()
        {
            return RequestBody.CarrierAccountPosteItalianeCreateRequest;
        }

        public CarrierAccountUPSCreateRequest? GetRequestBodyUps()
        {
            return RequestBody.CarrierAccountUPSCreateRequest;
        }

        public CarrierAccountUSPSCreateRequest? GetRequestBodyUsps()
        {
            return RequestBody.CarrierAccountUSPSCreateRequest;
        }

        public CarrierAccountSendleCreateRequest? GetRequestBodySendle()
        {
            return RequestBody.CarrierAccountSendleCreateRequest;
        }

        /// <summary>
        /// Optional string used to pick a non-default API version to use. See our &lt;a href=&quot;https://docs.goshippo.com/docs/api_concepts/apiversioning/&quot;&gt;API version&lt;/a&gt; guide.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }
    }
}