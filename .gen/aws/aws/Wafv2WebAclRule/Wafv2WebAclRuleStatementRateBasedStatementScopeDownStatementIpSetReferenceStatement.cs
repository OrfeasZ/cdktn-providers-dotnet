using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement
    {
        /// <summary>ARN of the IP set to reference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#arn Wafv2WebAclRuleA#arn}
        /// </remarks>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        private object? _ipSetForwardedIpConfig;

        /// <summary>ip_set_forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#ip_set_forwarded_ip_config Wafv2WebAclRuleA#ip_set_forwarded_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetForwardedIpConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementIpSetForwardedIpConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpSetForwardedIpConfig
        {
            get => _ipSetForwardedIpConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementIpSetForwardedIpConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementIpSetForwardedIpConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipSetForwardedIpConfig = value;
            }
        }
    }
}
