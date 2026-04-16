using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecord
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareDnsRecordFilter), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilter")]
    public interface IDataCloudflareDnsRecordFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#comment DataCloudflareDnsRecord#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterComment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterComment? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#content DataCloudflareDnsRecord#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterContent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterContent? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Direction to order DNS records in. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#direction DataCloudflareDnsRecord#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to match all search requirements or at least one (any).</summary>
        /// <remarks>
        /// If set to <c>all</c>, acts like a logical AND between filters. If set to <c>any</c>, acts like a logical OR instead. Note that the interaction between tag filters is controlled by the <c>tag-match</c> parameter instead.
        /// Available values: "any", "all".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#match DataCloudflareDnsRecord#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#name DataCloudflareDnsRecord#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterName? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order DNS records by. Available values: "type", "name", "content", "ttl", "proxied".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#order DataCloudflareDnsRecord#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the record is receiving the performance and security benefits of Cloudflare.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#proxied DataCloudflareDnsRecord#proxied}
        /// </remarks>
        [JsiiProperty(name: "proxied", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Proxied
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows searching in multiple properties of a DNS record simultaneously.</summary>
        /// <remarks>
        /// This parameter is intended for human users, not automation. Its exact behavior is intentionally left unspecified and is subject to change in the future. This parameter works independently of the <c>match</c> setting. For automated searches, please use the other available parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#search DataCloudflareDnsRecord#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#tag DataCloudflareDnsRecord#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterTag\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterTag? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to match all tag search requirements or at least one (any).</summary>
        /// <remarks>
        /// If set to <c>all</c>, acts like a logical AND between tag filters. If set to <c>any</c>, acts like a logical OR instead. Note that the regular <c>match</c> parameter is still used to combine the resulting condition with other filters that aren't related to tags.
        /// Available values: "any", "all".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#tag_match DataCloudflareDnsRecord#tag_match}
        /// </remarks>
        [JsiiProperty(name: "tagMatch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Record type.</summary>
        /// <remarks>
        /// Available values: "A", "AAAA", "CAA", "CERT", "CNAME", "DNSKEY", "DS", "HTTPS", "LOC", "MX", "NAPTR", "NS", "OPENPGPKEY", "PTR", "SMIMEA", "SRV", "SSHFP", "SVCB", "TLSA", "TXT", "URI".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#type DataCloudflareDnsRecord#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareDnsRecordFilter), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#comment DataCloudflareDnsRecord#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterComment\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterComment? Comment
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterComment?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#content DataCloudflareDnsRecord#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterContent\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterContent? Content
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterContent?>();
            }

            /// <summary>Direction to order DNS records in. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#direction DataCloudflareDnsRecord#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to match all search requirements or at least one (any).</summary>
            /// <remarks>
            /// If set to <c>all</c>, acts like a logical AND between filters. If set to <c>any</c>, acts like a logical OR instead. Note that the interaction between tag filters is controlled by the <c>tag-match</c> parameter instead.
            /// Available values: "any", "all".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#match DataCloudflareDnsRecord#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Match
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#name DataCloudflareDnsRecord#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterName\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterName? Name
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterName?>();
            }

            /// <summary>Field to order DNS records by. Available values: "type", "name", "content", "ttl", "proxied".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#order DataCloudflareDnsRecord#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the record is receiving the performance and security benefits of Cloudflare.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#proxied DataCloudflareDnsRecord#proxied}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxied", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Proxied
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allows searching in multiple properties of a DNS record simultaneously.</summary>
            /// <remarks>
            /// This parameter is intended for human users, not automation. Its exact behavior is intentionally left unspecified and is subject to change in the future. This parameter works independently of the <c>match</c> setting. For automated searches, please use the other available parameters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#search DataCloudflareDnsRecord#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#tag DataCloudflareDnsRecord#tag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterTag\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterTag? Tag
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterTag?>();
            }

            /// <summary>Whether to match all tag search requirements or at least one (any).</summary>
            /// <remarks>
            /// If set to <c>all</c>, acts like a logical AND between tag filters. If set to <c>any</c>, acts like a logical OR instead. Note that the regular <c>match</c> parameter is still used to combine the resulting condition with other filters that aren't related to tags.
            /// Available values: "any", "all".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#tag_match DataCloudflareDnsRecord#tag_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagMatch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagMatch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Record type.</summary>
            /// <remarks>
            /// Available values: "A", "AAAA", "CAA", "CERT", "CNAME", "DNSKEY", "DS", "HTTPS", "LOC", "MX", "NAPTR", "NS", "OPENPGPKEY", "PTR", "SMIMEA", "SRV", "SSHFP", "SVCB", "TLSA", "TXT", "URI".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#type DataCloudflareDnsRecord#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
