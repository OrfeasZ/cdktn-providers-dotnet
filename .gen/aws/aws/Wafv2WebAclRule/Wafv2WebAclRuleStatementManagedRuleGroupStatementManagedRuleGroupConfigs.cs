using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs
    {
        private object? _awsManagedRulesAcfpRuleSet;

        /// <summary>aws_managed_rules_acfp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_acfp_rule_set Wafv2WebAclRuleA#aws_managed_rules_acfp_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAcfpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAcfpRuleSet = value;
            }
        }

        private object? _awsManagedRulesAntiDdosRuleSet;

        /// <summary>aws_managed_rules_anti_ddos_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_anti_ddos_rule_set Wafv2WebAclRuleA#aws_managed_rules_anti_ddos_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAntiDdosRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAntiDdosRuleSet = value;
            }
        }

        private object? _awsManagedRulesAtpRuleSet;

        /// <summary>aws_managed_rules_atp_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_atp_rule_set Wafv2WebAclRuleA#aws_managed_rules_atp_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesAtpRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesAtpRuleSet = value;
            }
        }

        private object? _awsManagedRulesBotControlRuleSet;

        /// <summary>aws_managed_rules_bot_control_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#aws_managed_rules_bot_control_rule_set Wafv2WebAclRuleA#aws_managed_rules_bot_control_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedRulesBotControlRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsManagedRulesBotControlRuleSet = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#login_path Wafv2WebAclRuleA#login_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoginPath
        {
            get;
            set;
        }

        private object? _passwordField;

        /// <summary>password_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PasswordField
        {
            get => _passwordField;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _passwordField = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayloadType
        {
            get;
            set;
        }

        private object? _usernameField;

        /// <summary>username_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UsernameField
        {
            get => _usernameField;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _usernameField = value;
            }
        }
    }
}
