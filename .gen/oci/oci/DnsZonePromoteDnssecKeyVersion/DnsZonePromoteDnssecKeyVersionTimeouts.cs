using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsZonePromoteDnssecKeyVersion
{
    [JsiiByValue(fqn: "oci.dnsZonePromoteDnssecKeyVersion.DnsZonePromoteDnssecKeyVersionTimeouts")]
    public class DnsZonePromoteDnssecKeyVersionTimeouts : oci.DnsZonePromoteDnssecKeyVersion.IDnsZonePromoteDnssecKeyVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#create DnsZonePromoteDnssecKeyVersion#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#delete DnsZonePromoteDnssecKeyVersion#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#update DnsZonePromoteDnssecKeyVersion#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
