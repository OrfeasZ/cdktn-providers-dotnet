using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsActionCreateZoneFromZoneFile
{
    [JsiiByValue(fqn: "oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeouts")]
    public class DnsActionCreateZoneFromZoneFileTimeouts : oci.DnsActionCreateZoneFromZoneFile.IDnsActionCreateZoneFromZoneFileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file#create DnsActionCreateZoneFromZoneFile#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file#delete DnsActionCreateZoneFromZoneFile#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file#update DnsActionCreateZoneFromZoneFile#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
