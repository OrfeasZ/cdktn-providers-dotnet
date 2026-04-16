using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    [JsiiInterface(nativeType: typeof(ICustomHostnameSslCustomCertBundle), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSslCustomCertBundle")]
    public interface ICustomHostnameSslCustomCertBundle
    {
        /// <summary>If a custom uploaded certificate is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
        /// </remarks>
        [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string CustomCertificate
        {
            get;
        }

        /// <summary>The key for a custom uploaded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
        /// </remarks>
        [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}")]
        string CustomKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomHostnameSslCustomCertBundle), fullyQualifiedName: "cloudflare.customHostname.CustomHostnameSslCustomCertBundle")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CustomHostname.ICustomHostnameSslCustomCertBundle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If a custom uploaded certificate is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
            /// </remarks>
            [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomCertificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The key for a custom uploaded certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
            /// </remarks>
            [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
