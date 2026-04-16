using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride")]
    public class Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride
    {
        /// <summary>Name of the rule to override.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#name Wafv2WebAclRuleGroupAssociation#name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#action_to_use Wafv2WebAclRuleGroupAssociation#action_to_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actionToUse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _actionToUse = value;
            }
        }
    }
}
