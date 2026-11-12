using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccessRule
{
    [JsiiInterface(nativeType: typeof(IAccessRuleConfiguration), fullyQualifiedName: "cloudflare.accessRule.AccessRuleConfiguration")]
    public interface IAccessRuleConfiguration
    {
        /// <summary>For `target: ip`: The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the rule.
        ///
        /// For <c>target: ip6</c>: The configuration target. You must set the target to <c>ip6</c> when specifying an IPv6 address in the rule.
        ///
        /// For <c>target: ip_range</c>: The configuration target. You must set the target to <c>ip_range</c> when specifying an IP address range in the rule.
        ///
        /// For <c>target: asn</c>: The configuration target. You must set the target to <c>asn</c> when specifying an Autonomous System Number (ASN) in the rule.
        ///
        /// For <c>target: country</c>: The configuration target. You must set the target to <c>country</c> when specifying a country code in the rule.
        /// Available values: "ip", "ip6", "ip_range", "asn", "country".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/access_rule#target AccessRule#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `target: ip`: The IP address to match.</summary>
        /// <remarks>
        /// This address will be compared to the IP address of incoming requests.
        ///
        /// For <c>target: ip6</c>: The IPv6 address to match.
        ///
        /// For <c>target: ip_range</c>: The IP address range to match. You can only use prefix lengths <c>/16</c> and <c>/24</c> for IPv4 ranges, and prefix lengths <c>/32</c>, <c>/48</c>, and <c>/64</c> for IPv6 ranges.
        ///
        /// For <c>target: asn</c>: The AS number to match.
        ///
        /// For <c>target: country</c>: The two-letter ISO-3166-1 alpha-2 code to match. For more information, refer to <a href="https://developers.cloudflare.com/waf/tools/ip-access-rules/parameters/#country">IP Access rules: Parameters</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/access_rule#value AccessRule#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessRuleConfiguration), fullyQualifiedName: "cloudflare.accessRule.AccessRuleConfiguration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccessRule.IAccessRuleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>For `target: ip`: The configuration target.</summary>
            /// <remarks>
            /// You must set the target to <c>ip</c> when specifying an IP address in the rule.
            ///
            /// For <c>target: ip6</c>: The configuration target. You must set the target to <c>ip6</c> when specifying an IPv6 address in the rule.
            ///
            /// For <c>target: ip_range</c>: The configuration target. You must set the target to <c>ip_range</c> when specifying an IP address range in the rule.
            ///
            /// For <c>target: asn</c>: The configuration target. You must set the target to <c>asn</c> when specifying an Autonomous System Number (ASN) in the rule.
            ///
            /// For <c>target: country</c>: The configuration target. You must set the target to <c>country</c> when specifying a country code in the rule.
            /// Available values: "ip", "ip6", "ip_range", "asn", "country".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/access_rule#target AccessRule#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `target: ip`: The IP address to match.</summary>
            /// <remarks>
            /// This address will be compared to the IP address of incoming requests.
            ///
            /// For <c>target: ip6</c>: The IPv6 address to match.
            ///
            /// For <c>target: ip_range</c>: The IP address range to match. You can only use prefix lengths <c>/16</c> and <c>/24</c> for IPv4 ranges, and prefix lengths <c>/32</c>, <c>/48</c>, and <c>/64</c> for IPv6 ranges.
            ///
            /// For <c>target: asn</c>: The AS number to match.
            ///
            /// For <c>target: country</c>: The two-letter ISO-3166-1 alpha-2 code to match. For more information, refer to <a href="https://developers.cloudflare.com/waf/tools/ip-access-rules/parameters/#country">IP Access rules: Parameters</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/access_rule#value AccessRule#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
