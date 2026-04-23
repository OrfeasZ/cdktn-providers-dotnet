using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatement")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatement
    {
        /// <summary>List of ASN numbers (0-4294967295).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#asn_list Wafv2WebAclRuleA#asn_list}
        /// </remarks>
        [JsiiProperty(name: "asnList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] AsnList
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
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatementForwardedIpConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatementForwardedIpConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAsnMatchStatementForwardedIpConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forwardedIpConfig = value;
            }
        }
    }
}
