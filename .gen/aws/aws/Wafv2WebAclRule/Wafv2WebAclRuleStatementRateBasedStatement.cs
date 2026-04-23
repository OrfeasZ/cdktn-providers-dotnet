using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatement
    {
        /// <summary>Setting that indicates how to aggregate the request counts. Valid values: IP, FORWARDED_IP, CUSTOM_KEYS, CONSTANT.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aggregate_key_type Wafv2WebAclRuleA#aggregate_key_type}
        /// </remarks>
        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public string AggregateKeyType
        {
            get;
            set;
        }

        /// <summary>Rate limit threshold (10-2000000000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#limit Wafv2WebAclRuleA#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public double Limit
        {
            get;
            set;
        }

        private object? _customKeys;

        /// <summary>custom_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#custom_keys Wafv2WebAclRuleA#custom_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomKeys
        {
            get => _customKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementCustomKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementCustomKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customKeys = value;
            }
        }

        /// <summary>Time window for AWS WAF to use to check the rate (60, 120, 300, 600).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#evaluation_window_sec Wafv2WebAclRuleA#evaluation_window_sec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluationWindowSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EvaluationWindowSec
        {
            get;
            set;
        }

        private object? _forwardedIpConfig;

        /// <summary>forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#forwarded_ip_config Wafv2WebAclRuleA#forwarded_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementForwardedIpConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ForwardedIpConfig
        {
            get => _forwardedIpConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementForwardedIpConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementForwardedIpConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forwardedIpConfig = value;
            }
        }

        private object? _scopeDownStatement;

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#scope_down_statement Wafv2WebAclRuleA#scope_down_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScopeDownStatement
        {
            get => _scopeDownStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scopeDownStatement = value;
            }
        }
    }
}
