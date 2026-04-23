using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs")]
    public interface IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs
    {
        /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_acfp_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsManagedRulesAcfpRuleSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_managed_rules_anti_ddos_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_anti_ddos_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsManagedRulesAntiDdosRuleSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_managed_rules_atp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_atp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_atp_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsManagedRulesAtpRuleSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_managed_rules_bot_control_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_bot_control_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsManagedRulesBotControlRuleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_acfp_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAcfpRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_anti_ddos_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_anti_ddos_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAntiDdosRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_atp_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_atp_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_atp_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAtpRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_bot_control_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleGroupAssociation#aws_managed_rules_bot_control_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesBotControlRuleSet
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
