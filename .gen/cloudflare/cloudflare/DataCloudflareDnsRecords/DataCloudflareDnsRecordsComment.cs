using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecords
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsComment")]
    public class DataCloudflareDnsRecordsComment : cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsComment
    {
        /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#absent DataCloudflareDnsRecords#absent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Absent
        {
            get;
            set;
        }

        /// <summary>Substring of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#contains DataCloudflareDnsRecords#contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contains
        {
            get;
            set;
        }

        /// <summary>Suffix of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#endswith DataCloudflareDnsRecords#endswith}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endswith
        {
            get;
            set;
        }

        /// <summary>Exact value of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#exact DataCloudflareDnsRecords#exact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>If this parameter is present, only records *with* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#present DataCloudflareDnsRecords#present}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Present
        {
            get;
            set;
        }

        /// <summary>Prefix of the DNS record comment. Comment filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#startswith DataCloudflareDnsRecords#startswith}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Startswith
        {
            get;
            set;
        }
    }
}
