using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiInterface(nativeType: typeof(IIntegrationIntegrationInstanceCustomEndpoint), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpoint")]
    public interface IIntegrationIntegrationInstanceCustomEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_zone_name IntegrationIntegrationInstance#dns_zone_name}.</summary>
        [JsiiProperty(name: "dnsZoneName", typeJson: "{\"primitive\":\"string\"}")]
        string DnsZoneName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#hostname IntegrationIntegrationInstance#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#certificate_secret_id IntegrationIntegrationInstance#certificate_secret_id}.</summary>
        [JsiiProperty(name: "certificateSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_type IntegrationIntegrationInstance#dns_type}.</summary>
        [JsiiProperty(name: "dnsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIntegrationIntegrationInstanceCustomEndpoint), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpoint")]
        internal sealed class _Proxy : DeputyBase, oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_zone_name IntegrationIntegrationInstance#dns_zone_name}.</summary>
            [JsiiProperty(name: "dnsZoneName", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsZoneName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#hostname IntegrationIntegrationInstance#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#certificate_secret_id IntegrationIntegrationInstance#certificate_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#dns_type IntegrationIntegrationInstance#dns_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
