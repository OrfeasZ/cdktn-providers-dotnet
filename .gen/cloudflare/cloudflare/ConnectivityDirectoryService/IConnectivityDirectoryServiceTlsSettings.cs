using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiInterface(nativeType: typeof(IConnectivityDirectoryServiceTlsSettings), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceTlsSettings")]
    public interface IConnectivityDirectoryServiceTlsSettings
    {
        /// <summary>TLS certificate verification mode for the connection to the origin.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"verify_full"</c> — verify certificate chain and hostname (default)</description>
        /// <description><c>"verify_ca"</c> — verify certificate chain only, skip hostname check</description>
        /// <description><c>"disabled"</c> — do not verify the server certificate at all</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#cert_verification_mode ConnectivityDirectoryService#cert_verification_mode}
        /// </remarks>
        [JsiiProperty(name: "certVerificationMode", typeJson: "{\"primitive\":\"string\"}")]
        string CertVerificationMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectivityDirectoryServiceTlsSettings), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceTlsSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceTlsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>TLS certificate verification mode for the connection to the origin.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"verify_full"</c> — verify certificate chain and hostname (default)</description>
            /// <description><c>"verify_ca"</c> — verify certificate chain only, skip hostname check</description>
            /// <description><c>"disabled"</c> — do not verify the server certificate at all</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#cert_verification_mode ConnectivityDirectoryService#cert_verification_mode}
            /// </remarks>
            [JsiiProperty(name: "certVerificationMode", typeJson: "{\"primitive\":\"string\"}")]
            public string CertVerificationMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
