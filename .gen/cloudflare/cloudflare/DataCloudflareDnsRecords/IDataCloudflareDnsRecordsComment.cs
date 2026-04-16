using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecords
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareDnsRecordsComment), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsComment")]
    public interface IDataCloudflareDnsRecordsComment
    {
        /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#absent DataCloudflareDnsRecords#absent}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#contains DataCloudflareDnsRecords#contains}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#endswith DataCloudflareDnsRecords#endswith}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#exact DataCloudflareDnsRecords#exact}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#present DataCloudflareDnsRecords#present}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#startswith DataCloudflareDnsRecords#startswith}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareDnsRecordsComment), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsComment")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsComment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#absent DataCloudflareDnsRecords#absent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Absent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Substring of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#contains DataCloudflareDnsRecords#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Suffix of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#endswith DataCloudflareDnsRecords#endswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endswith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Exact value of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#exact DataCloudflareDnsRecords#exact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If this parameter is present, only records *with* a comment are returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#present DataCloudflareDnsRecords#present}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Present
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Prefix of the DNS record comment. Comment filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#startswith DataCloudflareDnsRecords#startswith}
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
