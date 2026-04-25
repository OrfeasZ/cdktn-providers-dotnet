using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecords
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareDnsRecordsConfig), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsConfig")]
    public interface IDataCloudflareDnsRecordsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#comment DataCloudflareDnsRecords#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsComment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsComment? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#content DataCloudflareDnsRecords#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsContent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsContent? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Direction to order DNS records in. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#direction DataCloudflareDnsRecords#direction}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#match DataCloudflareDnsRecords#match}
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

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#max_items DataCloudflareDnsRecords#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#name DataCloudflareDnsRecords#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsName? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order DNS records by. Available values: "type", "name", "content", "ttl", "proxied".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#order DataCloudflareDnsRecords#order}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#proxied DataCloudflareDnsRecords#proxied}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#search DataCloudflareDnsRecords#search}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#tag DataCloudflareDnsRecords#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsTag\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsTag? Tag
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#tag_match DataCloudflareDnsRecords#tag_match}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#type DataCloudflareDnsRecords#type}
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

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#zone_id DataCloudflareDnsRecords#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareDnsRecordsConfig), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#comment DataCloudflareDnsRecords#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsComment\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsComment? Comment
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsComment?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#content DataCloudflareDnsRecords#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsContent\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsContent? Content
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsContent?>();
            }

            /// <summary>Direction to order DNS records in. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#direction DataCloudflareDnsRecords#direction}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#match DataCloudflareDnsRecords#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Match
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#max_items DataCloudflareDnsRecords#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#name DataCloudflareDnsRecords#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsName\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsName? Name
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsName?>();
            }

            /// <summary>Field to order DNS records by. Available values: "type", "name", "content", "ttl", "proxied".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#order DataCloudflareDnsRecords#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the record is receiving the performance and security benefits of Cloudflare.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#proxied DataCloudflareDnsRecords#proxied}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#search DataCloudflareDnsRecords#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#tag DataCloudflareDnsRecords#tag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsTag\"}", isOptional: true)]
            public cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsTag? Tag
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsTag?>();
            }

            /// <summary>Whether to match all tag search requirements or at least one (any).</summary>
            /// <remarks>
            /// If set to <c>all</c>, acts like a logical AND between tag filters. If set to <c>any</c>, acts like a logical OR instead. Note that the regular <c>match</c> parameter is still used to combine the resulting condition with other filters that aren't related to tags.
            /// Available values: "any", "all".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#tag_match DataCloudflareDnsRecords#tag_match}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#type DataCloudflareDnsRecords#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_records#zone_id DataCloudflareDnsRecords#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
