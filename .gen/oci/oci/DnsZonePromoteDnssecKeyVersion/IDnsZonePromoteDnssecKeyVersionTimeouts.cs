using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsZonePromoteDnssecKeyVersion
{
    [JsiiInterface(nativeType: typeof(IDnsZonePromoteDnssecKeyVersionTimeouts), fullyQualifiedName: "oci.dnsZonePromoteDnssecKeyVersion.DnsZonePromoteDnssecKeyVersionTimeouts")]
    public interface IDnsZonePromoteDnssecKeyVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#create DnsZonePromoteDnssecKeyVersion#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#delete DnsZonePromoteDnssecKeyVersion#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#update DnsZonePromoteDnssecKeyVersion#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsZonePromoteDnssecKeyVersionTimeouts), fullyQualifiedName: "oci.dnsZonePromoteDnssecKeyVersion.DnsZonePromoteDnssecKeyVersionTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DnsZonePromoteDnssecKeyVersion.IDnsZonePromoteDnssecKeyVersionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#create DnsZonePromoteDnssecKeyVersion#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#delete DnsZonePromoteDnssecKeyVersion#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_zone_promote_dnssec_key_version#update DnsZonePromoteDnssecKeyVersion#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
