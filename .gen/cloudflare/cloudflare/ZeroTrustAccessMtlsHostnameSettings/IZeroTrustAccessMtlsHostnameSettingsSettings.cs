using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessMtlsHostnameSettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessMtlsHostnameSettingsSettings), fullyQualifiedName: "cloudflare.zeroTrustAccessMtlsHostnameSettings.ZeroTrustAccessMtlsHostnameSettingsSettings")]
    public interface IZeroTrustAccessMtlsHostnameSettingsSettings
    {
        /// <summary>Request client certificates for this hostname in China.</summary>
        /// <remarks>
        /// Can only be set to true if this zone is china network enabled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#china_network ZeroTrustAccessMtlsHostnameSettings#china_network}
        /// </remarks>
        [JsiiProperty(name: "chinaNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ChinaNetwork
        {
            get;
        }

        /// <summary>Client Certificate Forwarding is a feature that takes the client cert provided by the eyeball to the edge, and forwards it to the origin as a HTTP header to allow logging on the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#client_certificate_forwarding ZeroTrustAccessMtlsHostnameSettings#client_certificate_forwarding}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateForwarding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ClientCertificateForwarding
        {
            get;
        }

        /// <summary>The hostname that these settings apply to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#hostname ZeroTrustAccessMtlsHostnameSettings#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessMtlsHostnameSettingsSettings), fullyQualifiedName: "cloudflare.zeroTrustAccessMtlsHostnameSettings.ZeroTrustAccessMtlsHostnameSettingsSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessMtlsHostnameSettings.IZeroTrustAccessMtlsHostnameSettingsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Request client certificates for this hostname in China.</summary>
            /// <remarks>
            /// Can only be set to true if this zone is china network enabled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#china_network ZeroTrustAccessMtlsHostnameSettings#china_network}
            /// </remarks>
            [JsiiProperty(name: "chinaNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ChinaNetwork
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Client Certificate Forwarding is a feature that takes the client cert provided by the eyeball to the edge, and forwards it to the origin as a HTTP header to allow logging on the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#client_certificate_forwarding ZeroTrustAccessMtlsHostnameSettings#client_certificate_forwarding}
            /// </remarks>
            [JsiiProperty(name: "clientCertificateForwarding", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ClientCertificateForwarding
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The hostname that these settings apply to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_mtls_hostname_settings#hostname ZeroTrustAccessMtlsHostnameSettings#hostname}
            /// </remarks>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
