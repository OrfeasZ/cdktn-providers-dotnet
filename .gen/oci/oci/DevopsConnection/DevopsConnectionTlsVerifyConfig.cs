using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsConnection.DevopsConnectionTlsVerifyConfig")]
    public class DevopsConnectionTlsVerifyConfig : oci.DevopsConnection.IDevopsConnectionTlsVerifyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#ca_certificate_bundle_id DevopsConnection#ca_certificate_bundle_id}.</summary>
        [JsiiProperty(name: "caCertificateBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public string CaCertificateBundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_connection#tls_verify_mode DevopsConnection#tls_verify_mode}.</summary>
        [JsiiProperty(name: "tlsVerifyMode", typeJson: "{\"primitive\":\"string\"}")]
        public string TlsVerifyMode
        {
            get;
            set;
        }
    }
}
