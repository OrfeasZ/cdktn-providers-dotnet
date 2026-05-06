using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsRrset
{
    [JsiiInterface(nativeType: typeof(IDnsRrsetItems), fullyQualifiedName: "oci.dnsRrset.DnsRrsetItems")]
    public interface IDnsRrsetItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#domain DnsRrset#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rdata DnsRrset#rdata}.</summary>
        [JsiiProperty(name: "rdata", typeJson: "{\"primitive\":\"string\"}")]
        string Rdata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rtype DnsRrset#rtype}.</summary>
        [JsiiProperty(name: "rtype", typeJson: "{\"primitive\":\"string\"}")]
        string Rtype
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#ttl DnsRrset#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        double Ttl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsRrsetItems), fullyQualifiedName: "oci.dnsRrset.DnsRrsetItems")]
        internal sealed class _Proxy : DeputyBase, oci.DnsRrset.IDnsRrsetItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#domain DnsRrset#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rdata DnsRrset#rdata}.</summary>
            [JsiiProperty(name: "rdata", typeJson: "{\"primitive\":\"string\"}")]
            public string Rdata
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#rtype DnsRrset#rtype}.</summary>
            [JsiiProperty(name: "rtype", typeJson: "{\"primitive\":\"string\"}")]
            public string Rtype
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_rrset#ttl DnsRrset#ttl}.</summary>
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
            public double Ttl
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
