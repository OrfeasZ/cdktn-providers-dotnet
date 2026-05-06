using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsRrset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dnsRrset.DnsRrsetItems")]
    public class DnsRrsetItems : oci.DnsRrset.IDnsRrsetItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#domain DnsRrset#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public string Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rdata DnsRrset#rdata}.</summary>
        [JsiiProperty(name: "rdata", typeJson: "{\"primitive\":\"string\"}")]
        public string Rdata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rtype DnsRrset#rtype}.</summary>
        [JsiiProperty(name: "rtype", typeJson: "{\"primitive\":\"string\"}")]
        public string Rtype
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#ttl DnsRrset#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public double Ttl
        {
            get;
            set;
        }
    }
}
