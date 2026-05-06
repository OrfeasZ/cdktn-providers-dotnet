using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsZone
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dnsZone.DnsZoneExternalMasters")]
    public class DnsZoneExternalMasters : oci.DnsZone.IDnsZoneExternalMasters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#address DnsZone#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#port DnsZone#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#tsig_key_id DnsZone#tsig_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tsigKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TsigKeyId
        {
            get;
            set;
        }
    }
}
