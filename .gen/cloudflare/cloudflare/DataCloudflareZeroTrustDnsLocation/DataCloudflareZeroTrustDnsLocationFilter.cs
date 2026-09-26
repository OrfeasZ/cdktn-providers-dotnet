using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocation
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationFilter")]
    public class DataCloudflareZeroTrustDnsLocationFilter : cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationFilter
    {
        /// <summary>Sort direction.</summary>
        /// <remarks>
        /// Only takes effect when <c>order_by</c> is also provided; it
        /// is ignored otherwise. When <c>direction</c> is omitted the effective
        /// direction is field-specific: <c>created_at</c> and <c>updated_at</c> default to
        /// descending (newest first); <c>name</c> defaults to ascending.
        ///
        /// <list type="bullet">
        /// <description><c>asc</c> — ascending.</description>
        /// <description><c>desc</c> — descending.
        /// Available values: "asc", "desc".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_location#direction DataCloudflareZeroTrustDnsLocation#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Filter the returned locations by one or more `field:value` pairs.</summary>
        /// <remarks>
        /// Repeat the parameter to apply multiple filters; they are combined with
        /// logical AND (a location must satisfy every filter to be returned).
        ///
        /// Supported fields and their matching behaviour:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — case-insensitive substring match on the location name.</description>
        /// <description><c>id</c> — substring match on the location ID (UUID), with or without dashes.</description>
        /// <description><c>is_default</c> — whether it is the default for the account.</description>
        /// </list>
        ///
        /// Each entry must match one of the per-field patterns below:
        ///
        /// <list type="bullet">
        /// <description>the field must be one of <c>name</c>, <c>id</c>, or <c>is_default</c>;</description>
        /// <description><c>name</c>/<c>id</c> accept any value;</description>
        /// <description><c>is_default</c> only accepts <c>true</c> or <c>false</c>; any other value returns <c>400</c></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_location#filter DataCloudflareZeroTrustDnsLocation#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Filter
        {
            get;
            set;
        }

        /// <summary>Field to sort the returned locations by.</summary>
        /// <remarks>
        /// When omitted, the order of
        /// results is unspecified. Supported values:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — sort alphabetically by location name.</description>
        /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
        /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.
        /// Available values: "name", "created_at", "updated_at".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_location#order_by DataCloudflareZeroTrustDnsLocation#order_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderBy
        {
            get;
            set;
        }

        /// <summary>Case-insensitive substring match on the location name. When combined with `filter`, both must match (logical AND).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_location#search DataCloudflareZeroTrustDnsLocation#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
