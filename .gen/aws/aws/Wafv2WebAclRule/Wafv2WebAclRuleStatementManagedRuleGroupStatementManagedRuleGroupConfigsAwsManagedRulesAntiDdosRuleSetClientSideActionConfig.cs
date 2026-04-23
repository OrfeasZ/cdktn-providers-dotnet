using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig
    {
        private object? _challenge;

        /// <summary>challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#challenge Wafv2WebAclRuleA#challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Challenge
        {
            get => _challenge;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _challenge = value;
            }
        }
    }
}
