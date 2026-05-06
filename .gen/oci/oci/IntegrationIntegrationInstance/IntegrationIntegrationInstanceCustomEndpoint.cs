using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpoint")]
    public class IntegrationIntegrationInstanceCustomEndpoint : oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_zone_name IntegrationIntegrationInstance#dns_zone_name}.</summary>
        [JsiiProperty(name: "dnsZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsZoneName
        {
            get;
            set;
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_type IntegrationIntegrationInstance#dns_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsType
        {
            get;
            set;
        }
    }
}
