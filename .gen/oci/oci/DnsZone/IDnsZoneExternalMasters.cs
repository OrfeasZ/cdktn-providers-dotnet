using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsZone
{
    [JsiiInterface(nativeType: typeof(IDnsZoneExternalMasters), fullyQualifiedName: "oci.dnsZone.DnsZoneExternalMasters")]
    public interface IDnsZoneExternalMasters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#address DnsZone#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#port DnsZone#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#tsig_key_id DnsZone#tsig_key_id}.</summary>
        [JsiiProperty(name: "tsigKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsigKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsZoneExternalMasters), fullyQualifiedName: "oci.dnsZone.DnsZoneExternalMasters")]
        internal sealed class _Proxy : DeputyBase, oci.DnsZone.IDnsZoneExternalMasters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#address DnsZone#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#port DnsZone#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone#tsig_key_id DnsZone#tsig_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tsigKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsigKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
