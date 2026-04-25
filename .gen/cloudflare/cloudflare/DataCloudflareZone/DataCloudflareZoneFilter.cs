using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZone
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZone.DataCloudflareZoneFilter")]
    public class DataCloudflareZoneFilter : cloudflare.DataCloudflareZone.IDataCloudflareZoneFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#account DataCloudflareZone#account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneFilterAccount\"}", isOptional: true)]
        public cloudflare.DataCloudflareZone.IDataCloudflareZoneFilterAccount? Account
        {
            get;
            set;
        }

        /// <summary>Direction to order zones. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#direction DataCloudflareZone#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Whether to match all search requirements or at least one (any). Available values: "any", "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#match DataCloudflareZone#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Match
        {
            get;
            set;
        }

        /// <summary>A domain name.</summary>
        /// <remarks>
        /// Optional filter operators can be provided to extend refine the search:
        ///
        /// <list type="bullet">
        /// <description><c>equal</c> (default)</description>
        /// <description><c>not_equal</c></description>
        /// <description><c>starts_with</c></description>
        /// <description><c>ends_with</c></description>
        /// <description><c>contains</c></description>
        /// <description><c>starts_with_case_sensitive</c></description>
        /// <description><c>ends_with_case_sensitive</c></description>
        /// <description><c>contains_case_sensitive</c></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#name DataCloudflareZone#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Field to order zones by. Available values: "name", "status", "account.id", "account.name", "plan.id".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#order DataCloudflareZone#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Specify a zone status to filter by. Available values: "initializing", "pending", "active", "moved".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#status DataCloudflareZone#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
