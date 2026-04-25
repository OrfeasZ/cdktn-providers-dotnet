using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomSsl
{
    [JsiiInterface(nativeType: typeof(ICustomSslGeoRestrictions), fullyQualifiedName: "cloudflare.customSsl.CustomSslGeoRestrictions")]
    public interface ICustomSslGeoRestrictions
    {
        /// <summary>Available values: "us", "eu", "highest_security".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/custom_ssl#label CustomSsl#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomSslGeoRestrictions), fullyQualifiedName: "cloudflare.customSsl.CustomSslGeoRestrictions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CustomSsl.ICustomSslGeoRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "us", "eu", "highest_security".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/custom_ssl#label CustomSsl#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
