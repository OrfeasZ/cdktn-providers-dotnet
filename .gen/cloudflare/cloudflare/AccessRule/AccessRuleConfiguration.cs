using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccessRule
{
    [JsiiByValue(fqn: "cloudflare.accessRule.AccessRuleConfiguration")]
    public class AccessRuleConfiguration : cloudflare.AccessRule.IAccessRuleConfiguration
    {
        /// <summary>The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the rule.
        /// Available values: "ip", "ip6", "ip_range", "asn", "country".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#target AccessRule#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#value AccessRule#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
