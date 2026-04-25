using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FirewallRule
{
    [JsiiByValue(fqn: "cloudflare.firewallRule.FirewallRuleActionResponse")]
    public class FirewallRuleActionResponse : cloudflare.FirewallRule.IFirewallRuleActionResponse
    {
        /// <summary>The response body to return. The value must conform to the configured content type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/firewall_rule#body FirewallRule#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Body
        {
            get;
            set;
        }

        /// <summary>The content type of the body. Must be one of the following: `text/plain`, `text/xml`, or `application/json`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/firewall_rule#content_type FirewallRule#content_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }
    }
}
