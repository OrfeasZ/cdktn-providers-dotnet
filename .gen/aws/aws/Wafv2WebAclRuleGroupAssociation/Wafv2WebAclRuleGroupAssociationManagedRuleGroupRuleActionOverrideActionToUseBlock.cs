using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlock")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlock : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlock
    {
        private object? _customResponse;

        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#custom_response Wafv2WebAclRuleGroupAssociation#custom_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomResponse
        {
            get => _customResponse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customResponse = value;
            }
        }
    }
}
