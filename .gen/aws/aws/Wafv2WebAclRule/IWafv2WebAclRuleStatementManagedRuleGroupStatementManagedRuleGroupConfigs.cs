using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs
    {
        /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleA#aws_managed_rules_acfp_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleA#aws_managed_rules_anti_ddos_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_atp_rule_set Wafv2WebAclRuleA#aws_managed_rules_atp_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleA#aws_managed_rules_bot_control_rule_set}
        /// </remarks>
        [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsManagedRulesBotControlRuleSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#login_path Wafv2WebAclRuleA#login_path}.</summary>
        [JsiiProperty(name: "loginPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoginPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>password_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
        /// </remarks>
        [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PasswordField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayloadType
        {
            get
            {
                return null;
            }
        }

        /// <summary>username_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
        /// </remarks>
        [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UsernameField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleA#aws_managed_rules_acfp_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAcfpRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_anti_ddos_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleA#aws_managed_rules_anti_ddos_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAntiDdosRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_atp_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_atp_rule_set Wafv2WebAclRuleA#aws_managed_rules_atp_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesAtpRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_managed_rules_bot_control_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleA#aws_managed_rules_bot_control_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsManagedRulesBotControlRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#login_path Wafv2WebAclRuleA#login_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoginPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>password_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PasswordField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayloadType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>username_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UsernameField
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
