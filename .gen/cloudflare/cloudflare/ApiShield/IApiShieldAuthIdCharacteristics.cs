using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShield
{
    [JsiiInterface(nativeType: typeof(IApiShieldAuthIdCharacteristics), fullyQualifiedName: "cloudflare.apiShield.ApiShieldAuthIdCharacteristics")]
    public interface IApiShieldAuthIdCharacteristics
    {
        /// <summary>The name of the characteristic field, i.e., the header or cookie name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_shield#name ApiShield#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The type of characteristic. Available values: "header", "cookie", "jwt".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_shield#type ApiShield#type}
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

            /// <summary>The name of the characteristic field, i.e., the header or cookie name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_shield#name ApiShield#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of characteristic. Available values: "header", "cookie", "jwt".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_shield#type ApiShield#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
