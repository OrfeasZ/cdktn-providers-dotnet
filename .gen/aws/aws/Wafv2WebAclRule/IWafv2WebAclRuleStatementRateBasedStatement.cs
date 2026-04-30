using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatement
    {
        /// <summary>Setting that indicates how to aggregate the request counts. Valid values: IP, FORWARDED_IP, CUSTOM_KEYS, CONSTANT.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#aggregate_key_type Wafv2WebAclRuleA#aggregate_key_type}
        /// </remarks>
        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}")]
        string AggregateKeyType
        {
            get;
        }

        /// <summary>Rate limit threshold (10-2000000000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#limit Wafv2WebAclRuleA#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        /// <summary>custom_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#custom_keys Wafv2WebAclRuleA#custom_keys}
        /// </remarks>
        [JsiiProperty(name: "customKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time window for AWS WAF to use to check the rate (60, 120, 300, 600).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#evaluation_window_sec Wafv2WebAclRuleA#evaluation_window_sec}
        /// </remarks>
        [JsiiProperty(name: "evaluationWindowSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EvaluationWindowSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#forwarded_ip_config Wafv2WebAclRuleA#forwarded_ip_config}
        /// </remarks>
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementForwardedIpConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForwardedIpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#scope_down_statement Wafv2WebAclRuleA#scope_down_statement}
        /// </remarks>
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScopeDownStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Setting that indicates how to aggregate the request counts. Valid values: IP, FORWARDED_IP, CUSTOM_KEYS, CONSTANT.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#aggregate_key_type Wafv2WebAclRuleA#aggregate_key_type}
            /// </remarks>
            [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}")]
            public string AggregateKeyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Rate limit threshold (10-2000000000).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#limit Wafv2WebAclRuleA#limit}
            /// </remarks>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>custom_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#custom_keys Wafv2WebAclRuleA#custom_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Time window for AWS WAF to use to check the rate (60, 120, 300, 600).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#evaluation_window_sec Wafv2WebAclRuleA#evaluation_window_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluationWindowSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EvaluationWindowSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>forwarded_ip_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#forwarded_ip_config Wafv2WebAclRuleA#forwarded_ip_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementForwardedIpConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ForwardedIpConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scope_down_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#scope_down_statement Wafv2WebAclRuleA#scope_down_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScopeDownStatement
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
