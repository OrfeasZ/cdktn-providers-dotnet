using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecord
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterComment")]
    public class DataCloudflareDnsRecordFilterComment : cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterComment
    {
        /// <summary>If this parameter is present, only records *without* a comment are returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#absent DataCloudflareDnsRecord#absent}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#contains DataCloudflareDnsRecord#contains}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#endswith DataCloudflareDnsRecord#endswith}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#exact DataCloudflareDnsRecord#exact}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#present DataCloudflareDnsRecord#present}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_record#startswith DataCloudflareDnsRecord#startswith}
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
