using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShield
{
    [JsiiInterface(nativeType: typeof(IApiShieldAuthIdCharacteristics), fullyQualifiedName: "cloudflare.apiShield.ApiShieldAuthIdCharacteristics")]
    public interface IApiShieldAuthIdCharacteristics
    {
        /// <summary>The name of the characteristic field, i.e., the header or cookie name. When using type "jwt", this must be a claim location expressed as `$(token_config_id):$(json_path)`, where `token_config_id` is the ID of the token configuration used in validating the JWT, and `json_path` is a RFC 9535 JSONPath expression.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield#name ApiShield#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The type of characteristic. Available values: "header", "cookie", "jwt".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield#type ApiShield#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiShieldAuthIdCharacteristics), fullyQualifiedName: "cloudflare.apiShield.ApiShieldAuthIdCharacteristics")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiShield.IApiShieldAuthIdCharacteristics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the characteristic field, i.e., the header or cookie name. When using type "jwt", this must be a claim location expressed as `$(token_config_id):$(json_path)`, where `token_config_id` is the ID of the token configuration used in validating the JWT, and `json_path` is a RFC 9535 JSONPath expression.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield#name ApiShield#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of characteristic. Available values: "header", "cookie", "jwt".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield#type ApiShield#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
