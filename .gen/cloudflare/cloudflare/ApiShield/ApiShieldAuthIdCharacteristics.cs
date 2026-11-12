using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShield
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.apiShield.ApiShieldAuthIdCharacteristics")]
    public class ApiShieldAuthIdCharacteristics : cloudflare.ApiShield.IApiShieldAuthIdCharacteristics
    {
        /// <summary>For `type: header` or `type: cookie`: The name of the characteristic field, i.e., the header or cookie name.</summary>
        /// <remarks>
        /// For <c>type: jwt</c>: Claim location expressed as <c>$(token_config_id):$(json_path)</c>, where <c>token_config_id</c>
        /// is the ID of the token configuration used in validating the JWT, and <c>json_path</c> is a RFC 9535
        /// JSONPath (https://goessner.net/articles/JsonPath/, https://www.rfc-editor.org/rfc/rfc9535.html).
        /// The JSONPath expression may be in dot or bracket notation, may only specify literal keys
        /// or array indexes, and must return a singleton value, which will be interpreted as a string.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/api_shield#name ApiShield#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The type of characteristic. Available values: "header", "cookie", "jwt".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/api_shield#type ApiShield#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
