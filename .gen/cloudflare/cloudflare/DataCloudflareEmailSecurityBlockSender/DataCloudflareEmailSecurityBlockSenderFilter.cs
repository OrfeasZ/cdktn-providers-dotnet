using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailSecurityBlockSender
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareEmailSecurityBlockSender.DataCloudflareEmailSecurityBlockSenderFilter")]
    public class DataCloudflareEmailSecurityBlockSenderFilter : cloudflare.DataCloudflareEmailSecurityBlockSender.IDataCloudflareEmailSecurityBlockSenderFilter
    {
        /// <summary>The sorting direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/email_security_block_sender#direction DataCloudflareEmailSecurityBlockSender#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Field to sort by. Available values: "pattern", "created_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/email_security_block_sender#order DataCloudflareEmailSecurityBlockSender#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Filter by pattern value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/email_security_block_sender#pattern DataCloudflareEmailSecurityBlockSender#pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pattern
        {
            get;
            set;
        }

        /// <summary>Filter by pattern type. Available values: "EMAIL", "DOMAIN", "IP", "UNKNOWN".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/email_security_block_sender#pattern_type DataCloudflareEmailSecurityBlockSender#pattern_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patternType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatternType
        {
            get;
            set;
        }

        /// <summary>Search term for filtering records. Behavior may change.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/email_security_block_sender#search DataCloudflareEmailSecurityBlockSender#search}
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
