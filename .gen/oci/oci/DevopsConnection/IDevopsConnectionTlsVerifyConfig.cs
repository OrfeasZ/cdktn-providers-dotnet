using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsConnection
{
    [JsiiInterface(nativeType: typeof(IDevopsConnectionTlsVerifyConfig), fullyQualifiedName: "oci.devopsConnection.DevopsConnectionTlsVerifyConfig")]
    public interface IDevopsConnectionTlsVerifyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#ca_certificate_bundle_id DevopsConnection#ca_certificate_bundle_id}.</summary>
        [JsiiProperty(name: "caCertificateBundleId", typeJson: "{\"primitive\":\"string\"}")]
        string CaCertificateBundleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#tls_verify_mode DevopsConnection#tls_verify_mode}.</summary>
        [JsiiProperty(name: "tlsVerifyMode", typeJson: "{\"primitive\":\"string\"}")]
        string TlsVerifyMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsConnectionTlsVerifyConfig), fullyQualifiedName: "oci.devopsConnection.DevopsConnectionTlsVerifyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsConnection.IDevopsConnectionTlsVerifyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#ca_certificate_bundle_id DevopsConnection#ca_certificate_bundle_id}.</summary>
            [JsiiProperty(name: "caCertificateBundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string CaCertificateBundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#tls_verify_mode DevopsConnection#tls_verify_mode}.</summary>
            [JsiiProperty(name: "tlsVerifyMode", typeJson: "{\"primitive\":\"string\"}")]
            public string TlsVerifyMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
