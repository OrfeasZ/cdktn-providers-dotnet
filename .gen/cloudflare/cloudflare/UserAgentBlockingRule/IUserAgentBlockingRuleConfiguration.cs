using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.UserAgentBlockingRule
{
    [JsiiInterface(nativeType: typeof(IUserAgentBlockingRuleConfiguration), fullyQualifiedName: "cloudflare.userAgentBlockingRule.UserAgentBlockingRuleConfiguration")]
    public interface IUserAgentBlockingRuleConfiguration
    {
        /// <summary>The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ua</c> when specifying a user agent in the rule.
        /// Available values: "ua".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_agent_blocking_rule#target UserAgentBlockingRule#target}
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

        /// <summary>the user agent to exactly match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_agent_blocking_rule#value UserAgentBlockingRule#value}
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

        [JsiiTypeProxy(nativeType: typeof(IUserAgentBlockingRuleConfiguration), fullyQualifiedName: "cloudflare.userAgentBlockingRule.UserAgentBlockingRuleConfiguration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.UserAgentBlockingRule.IUserAgentBlockingRuleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The configuration target.</summary>
            /// <remarks>
            /// You must set the target to <c>ua</c> when specifying a user agent in the rule.
            /// Available values: "ua".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_agent_blocking_rule#target UserAgentBlockingRule#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>the user agent to exactly match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_agent_blocking_rule#value UserAgentBlockingRule#value}
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
