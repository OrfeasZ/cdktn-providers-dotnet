using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatement
    {
        /// <summary>Name of the managed rule group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Name of the managed rule group vendor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#vendor_name Wafv2WebAclRuleA#vendor_name}
        /// </remarks>
        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        string VendorName
        {
            get;
        }

        /// <summary>managed_rule_group_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#managed_rule_group_configs Wafv2WebAclRuleA#managed_rule_group_configs}
        /// </remarks>
        [JsiiProperty(name: "managedRuleGroupConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedRuleGroupConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_action_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#rule_action_override Wafv2WebAclRuleA#rule_action_override}
        /// </remarks>
        [JsiiProperty(name: "ruleActionOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuleActionOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#scope_down_statement Wafv2WebAclRuleA#scope_down_statement}
        /// </remarks>
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScopeDownStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version of the managed rule group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#version Wafv2WebAclRuleA#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the managed rule group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the managed rule group vendor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#vendor_name Wafv2WebAclRuleA#vendor_name}
            /// </remarks>
            [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
            public string VendorName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>managed_rule_group_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#managed_rule_group_configs Wafv2WebAclRuleA#managed_rule_group_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedRuleGroupConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedRuleGroupConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rule_action_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#rule_action_override Wafv2WebAclRuleA#rule_action_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleActionOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuleActionOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scope_down_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#scope_down_statement Wafv2WebAclRuleA#scope_down_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScopeDownStatement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Version of the managed rule group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#version Wafv2WebAclRuleA#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
