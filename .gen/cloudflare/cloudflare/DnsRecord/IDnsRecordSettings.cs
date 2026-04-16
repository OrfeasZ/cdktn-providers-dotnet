using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsRecord
{
    [JsiiInterface(nativeType: typeof(IDnsRecordSettings), fullyQualifiedName: "cloudflare.dnsRecord.DnsRecordSettings")]
    public interface IDnsRecordSettings
    {
        /// <summary>If enabled, causes the CNAME record to be resolved externally and the resulting address records (e.g., A and AAAA) to be returned instead of the CNAME record itself. This setting is unavailable for proxied records, since they are always flattened.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#flatten_cname DnsRecord#flatten_cname}
        /// </remarks>
        [JsiiProperty(name: "flattenCname", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FlattenCname
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, only A records will be generated, and AAAA records will not be created.</summary>
        /// <remarks>
        /// This setting is intended for exceptional cases. Note that this option only applies to proxied records and it has no effect on whether Cloudflare communicates with the origin using IPv4 or IPv6.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#ipv4_only DnsRecord#ipv4_only}
        /// </remarks>
        [JsiiProperty(name: "ipv4Only", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv4Only
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, only AAAA records will be generated, and A records will not be created.</summary>
        /// <remarks>
        /// This setting is intended for exceptional cases. Note that this option only applies to proxied records and it has no effect on whether Cloudflare communicates with the origin using IPv4 or IPv6.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#ipv6_only DnsRecord#ipv6_only}
        /// </remarks>
        [JsiiProperty(name: "ipv6Only", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6Only
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsRecordSettings), fullyQualifiedName: "cloudflare.dnsRecord.DnsRecordSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DnsRecord.IDnsRecordSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If enabled, causes the CNAME record to be resolved externally and the resulting address records (e.g., A and AAAA) to be returned instead of the CNAME record itself. This setting is unavailable for proxied records, since they are always flattened.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#flatten_cname DnsRecord#flatten_cname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flattenCname", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FlattenCname
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled, only A records will be generated, and AAAA records will not be created.</summary>
            /// <remarks>
            /// This setting is intended for exceptional cases. Note that this option only applies to proxied records and it has no effect on whether Cloudflare communicates with the origin using IPv4 or IPv6.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#ipv4_only DnsRecord#ipv4_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Only", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv4Only
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled, only AAAA records will be generated, and A records will not be created.</summary>
            /// <remarks>
            /// This setting is intended for exceptional cases. Note that this option only applies to proxied records and it has no effect on whether Cloudflare communicates with the origin using IPv4 or IPv6.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#ipv6_only DnsRecord#ipv6_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Only", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv6Only
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
