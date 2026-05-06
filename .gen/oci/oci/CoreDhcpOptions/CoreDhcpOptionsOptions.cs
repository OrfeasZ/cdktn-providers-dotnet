using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDhcpOptions
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDhcpOptions.CoreDhcpOptionsOptions")]
    public class CoreDhcpOptionsOptions : oci.CoreDhcpOptions.ICoreDhcpOptionsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#type CoreDhcpOptions#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#custom_dns_servers CoreDhcpOptions#custom_dns_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customDnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomDnsServers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#search_domain_names CoreDhcpOptions#search_domain_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchDomainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SearchDomainNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#server_type CoreDhcpOptions#server_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerType
        {
            get;
            set;
        }
    }
}
