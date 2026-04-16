using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareUserAgentBlockingRule
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareUserAgentBlockingRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareUserAgentBlockingRule.DataCloudflareUserAgentBlockingRuleFilter")]
    public interface IDataCloudflareUserAgentBlockingRuleFilter
    {
        /// <summary>A string to search for in the description of existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#description DataCloudflareUserAgentBlockingRule#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, indicates that the rule is currently paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#paused DataCloudflareUserAgentBlockingRule#paused}
        /// </remarks>
        [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Paused
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string to search for in the user agent values of existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#user_agent DataCloudflareUserAgentBlockingRule#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAgent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareUserAgentBlockingRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareUserAgentBlockingRule.DataCloudflareUserAgentBlockingRuleFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareUserAgentBlockingRule.IDataCloudflareUserAgentBlockingRuleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A string to search for in the description of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#description DataCloudflareUserAgentBlockingRule#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, indicates that the rule is currently paused.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#paused DataCloudflareUserAgentBlockingRule#paused}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Paused
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A string to search for in the user agent values of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/user_agent_blocking_rule#user_agent DataCloudflareUserAgentBlockingRule#user_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAgent
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
