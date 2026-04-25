using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecord
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareDnsRecordFilterComment), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterComment")]
    public interface IDataCloudflareDnsRecordFilterComment
    {
        /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#absent DataCloudflareDnsRecord#absent}
        /// </remarks>
        [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Absent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Substring of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#contains DataCloudflareDnsRecord#contains}
        /// </remarks>
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Contains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Suffix of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#endswith DataCloudflareDnsRecord#endswith}
        /// </remarks>
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endswith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Exact value of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#exact DataCloudflareDnsRecord#exact}
        /// </remarks>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this parameter is present, only records *with* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#present DataCloudflareDnsRecord#present}
        /// </remarks>
        [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Present
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prefix of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#startswith DataCloudflareDnsRecord#startswith}
        /// </remarks>
        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Startswith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareDnsRecordFilterComment), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterComment")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterComment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#absent DataCloudflareDnsRecord#absent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Absent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Substring of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#contains DataCloudflareDnsRecord#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Suffix of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#endswith DataCloudflareDnsRecord#endswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endswith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Exact value of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#exact DataCloudflareDnsRecord#exact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If this parameter is present, only records *with* a comment are returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#present DataCloudflareDnsRecord#present}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Present
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Prefix of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#startswith DataCloudflareDnsRecord#startswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Startswith
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
