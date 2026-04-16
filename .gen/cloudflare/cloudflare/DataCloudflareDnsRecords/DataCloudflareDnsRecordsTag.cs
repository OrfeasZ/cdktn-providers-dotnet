using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecords
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareDnsRecords.DataCloudflareDnsRecordsTag")]
    public class DataCloudflareDnsRecordsTag : cloudflare.DataCloudflareDnsRecords.IDataCloudflareDnsRecordsTag
    {
        /// <summary>Name of a tag which must *not* be present on the DNS record. Tag filters are case-insensitive.</summary>
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

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value contains <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#contains DataCloudflareDnsRecords#contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contains
        {
            get;
            set;
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value ends with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#endswith DataCloudflareDnsRecords#endswith}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endswith
        {
            get;
            set;
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value is <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/dns_records#exact DataCloudflareDnsRecords#exact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>Name of a tag which must be present on the DNS record. Tag filters are case-insensitive.</summary>
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

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value starts with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
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
