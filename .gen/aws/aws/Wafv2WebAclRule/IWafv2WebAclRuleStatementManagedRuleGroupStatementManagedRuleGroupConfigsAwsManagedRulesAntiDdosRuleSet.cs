using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet
    {
        /// <summary>client_side_action_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#client_side_action_config Wafv2WebAclRuleA#client_side_action_config}
        /// </remarks>
        [JsiiProperty(name: "clientSideActionConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientSideActionConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#sensitivity_to_block Wafv2WebAclRuleA#sensitivity_to_block}.</summary>
        [JsiiProperty(name: "sensitivityToBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensitivityToBlock
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_side_action_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#client_side_action_config Wafv2WebAclRuleA#client_side_action_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSideActionConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClientSideActionConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#sensitivity_to_block Wafv2WebAclRuleA#sensitivity_to_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitivityToBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensitivityToBlock
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
