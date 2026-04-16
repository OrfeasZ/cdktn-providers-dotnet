using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationConfig), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationConfig")]
    public interface IWafv2WebAclRuleGroupAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Priority of the rule within the Web ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#priority Wafv2WebAclRuleGroupAssociation#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Name of the rule to create in the Web ACL that references the rule group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#rule_name Wafv2WebAclRuleGroupAssociation#rule_name}
        /// </remarks>
        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleName
        {
            get;
        }

        /// <summary>ARN of the Web ACL to associate the Rule Group with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#web_acl_arn Wafv2WebAclRuleGroupAssociation#web_acl_arn}
        /// </remarks>
        [JsiiProperty(name: "webAclArn", typeJson: "{\"primitive\":\"string\"}")]
        string WebAclArn
        {
            get;
        }

        /// <summary>managed_rule_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#managed_rule_group Wafv2WebAclRuleGroupAssociation#managed_rule_group}
        /// </remarks>
        [JsiiProperty(name: "managedRuleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedRuleGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Override action for the rule group. Valid values are 'none' and 'count'. Defaults to 'none'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#override_action Wafv2WebAclRuleGroupAssociation#override_action}
        /// </remarks>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverrideAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#region Wafv2WebAclRuleGroupAssociation#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_group_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#rule_group_reference Wafv2WebAclRuleGroupAssociation#rule_group_reference}
        /// </remarks>
        [JsiiProperty(name: "ruleGroupReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuleGroupReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#timeouts Wafv2WebAclRuleGroupAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#visibility_config Wafv2WebAclRuleGroupAssociation#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationVisibilityConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VisibilityConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationConfig), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Priority of the rule within the Web ACL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#priority Wafv2WebAclRuleGroupAssociation#priority}
            /// </remarks>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Name of the rule to create in the Web ACL that references the rule group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#rule_name Wafv2WebAclRuleGroupAssociation#rule_name}
            /// </remarks>
            [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the Web ACL to associate the Rule Group with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#web_acl_arn Wafv2WebAclRuleGroupAssociation#web_acl_arn}
            /// </remarks>
            [JsiiProperty(name: "webAclArn", typeJson: "{\"primitive\":\"string\"}")]
            public string WebAclArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>managed_rule_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#managed_rule_group Wafv2WebAclRuleGroupAssociation#managed_rule_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedRuleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedRuleGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Override action for the rule group. Valid values are 'none' and 'count'. Defaults to 'none'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#override_action Wafv2WebAclRuleGroupAssociation#override_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverrideAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#region Wafv2WebAclRuleGroupAssociation#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rule_group_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#rule_group_reference Wafv2WebAclRuleGroupAssociation#rule_group_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleGroupReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuleGroupReference
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#timeouts Wafv2WebAclRuleGroupAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationTimeouts\"}", isOptional: true)]
            public aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationTimeouts?>();
            }

            /// <summary>visibility_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#visibility_config Wafv2WebAclRuleGroupAssociation#visibility_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationVisibilityConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VisibilityConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
