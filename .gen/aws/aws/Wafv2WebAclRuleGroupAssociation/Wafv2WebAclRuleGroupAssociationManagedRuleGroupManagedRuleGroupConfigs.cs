using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs
    {
        private object? _awsManagedRulesAcfpRuleSet;

        /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_acfp_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsManagedRulesAcfpRuleSet
        {
            get => _awsManagedRulesAcfpRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAcfpRuleSet = value;
            }
        }

        private object? _awsManagedRulesAntiDdosRuleSet;

        /// <summary>aws_managed_rules_anti_ddos_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_anti_ddos_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsManagedRulesAntiDdosRuleSet
        {
            get => _awsManagedRulesAntiDdosRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAntiDdosRuleSet = value;
            }
        }

        private object? _awsManagedRulesAtpRuleSet;

        /// <summary>aws_managed_rules_atp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_atp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_atp_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsManagedRulesAtpRuleSet
        {
            get => _awsManagedRulesAtpRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAtpRuleSet = value;
            }
        }

        private object? _awsManagedRulesBotControlRuleSet;

        /// <summary>aws_managed_rules_bot_control_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_bot_control_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsManagedRulesBotControlRuleSet
        {
            get => _awsManagedRulesBotControlRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesBotControlRuleSet = value;
            }
        }
    }
}
