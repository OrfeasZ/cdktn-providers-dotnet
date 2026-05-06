using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsResolver
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dnsResolver.DnsResolverRules")]
    public class DnsResolverRules : oci.DnsResolver.IDnsResolverRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#action DnsResolver#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#destination_addresses DnsResolver#destination_addresses}.</summary>
        [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DestinationAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#source_endpoint_name DnsResolver#source_endpoint_name}.</summary>
        [JsiiProperty(name: "sourceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceEndpointName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#client_address_conditions DnsResolver#client_address_conditions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientAddressConditions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClientAddressConditions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#qname_cover_conditions DnsResolver#qname_cover_conditions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qnameCoverConditions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QnameCoverConditions
        {
            get;
            set;
        }
    }
}
