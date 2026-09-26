using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyFilter")]
    public class DataCloudflareZeroTrustGatewayPolicyFilter : cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyFilter
    {
        /// <summary>Sort direction.</summary>
        /// <remarks>
        /// When <c>order_by</c> is omitted, this controls the direction
        /// of the existing precedence ordering. Shared rules remain first in either
        /// direction. Accepted values are <c>asc</c> and <c>desc</c>.
        /// Available values: "asc", "desc".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_policy#direction DataCloudflareZeroTrustGatewayPolicy#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Filter the returned rules by one or more `field:value` pairs. Repeat the parameter to combine filters with logical AND.</summary>
        /// <remarks>
        /// Supported fields are <c>name</c>, <c>id</c>, <c>action</c>, <c>enabled</c>, <c>source_account</c>,
        /// <c>is_shared</c>, <c>filters</c>, and <c>expression</c> (max 1024 bytes). The <c>source_account</c>
        /// value is matched as a normalized UUID substring. The <c>filters</c> value must
        /// be one of the rule filter names and matches a member of the rule's <c>filters</c>
        /// array. The <c>expression</c> filter performs a case-insensitive literal
        /// substring match across traffic, identity, and device posture expressions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_policy#filter DataCloudflareZeroTrustGatewayPolicy#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Filter
        {
            get;
            set;
        }

        /// <summary>Field to sort the returned rules by. Supported values are `name`, `created_at`, `updated_at`, and `precedence`. Available values: "name", "created_at", "updated_at", "precedence".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_policy#order_by DataCloudflareZeroTrustGatewayPolicy#order_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderBy
        {
            get;
            set;
        }

        /// <summary>Case-insensitive substring search across rule name and description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_policy#search DataCloudflareZeroTrustGatewayPolicy#search}
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
