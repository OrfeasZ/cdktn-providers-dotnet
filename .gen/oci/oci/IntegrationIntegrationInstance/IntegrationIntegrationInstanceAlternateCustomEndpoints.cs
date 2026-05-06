using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpoints")]
    public class IntegrationIntegrationInstanceAlternateCustomEndpoints : oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceAlternateCustomEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#hostname IntegrationIntegrationInstance#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#certificate_secret_id IntegrationIntegrationInstance#certificate_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateSecretId
        {
            get;
            set;
        }
    }
}
