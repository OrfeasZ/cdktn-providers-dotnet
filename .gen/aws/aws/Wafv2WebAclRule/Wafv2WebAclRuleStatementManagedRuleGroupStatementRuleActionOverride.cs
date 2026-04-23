using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverride")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverride : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverride
    {
        /// <summary>Name of the rule to override (1-128 characters).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _actionToUse;

        /// <summary>action_to_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#action_to_use Wafv2WebAclRuleA#action_to_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actionToUse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ActionToUse
        {
            get => _actionToUse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _actionToUse = value;
            }
        }
    }
}
