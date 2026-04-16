using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse")]
    public interface IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#allow Wafv2WebAclRuleGroupAssociation#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseAllow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#block Wafv2WebAclRuleGroupAssociation#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlock\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>captcha block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#captcha Wafv2WebAclRuleGroupAssociation#captcha}
        /// </remarks>
        [JsiiProperty(name: "captcha", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCaptcha\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Captcha
        {
            get
            {
                return null;
            }
        }

        /// <summary>challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#challenge Wafv2WebAclRuleGroupAssociation#challenge}
        /// </remarks>
        [JsiiProperty(name: "challenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Challenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#count Wafv2WebAclRuleGroupAssociation#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#allow Wafv2WebAclRuleGroupAssociation#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseAllow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Allow
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#block Wafv2WebAclRuleGroupAssociation#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseBlock\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Block
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>captcha block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#captcha Wafv2WebAclRuleGroupAssociation#captcha}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captcha", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCaptcha\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Captcha
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#challenge Wafv2WebAclRuleGroupAssociation#challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "challenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Challenge
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#count Wafv2WebAclRuleGroupAssociation#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
