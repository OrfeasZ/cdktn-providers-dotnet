using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
        string PayloadType
        {
            get;
        }

        /// <summary>address_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#address_fields Wafv2WebAclRuleA#address_fields}
        /// </remarks>
        [JsiiProperty(name: "addressFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddressFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#email_field Wafv2WebAclRuleA#email_field}
        /// </remarks>
        [JsiiProperty(name: "emailField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmailField
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
        [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PasswordField
        {
            get
            {
                return null;
            }
        }

        /// <summary>phone_number_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#phone_number_fields Wafv2WebAclRuleA#phone_number_fields}
        /// </remarks>
        [JsiiProperty(name: "phoneNumberFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PhoneNumberFields
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
        [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UsernameField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
            [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
            public string PayloadType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>address_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#address_fields Wafv2WebAclRuleA#address_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddressFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>email_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#email_field Wafv2WebAclRuleA#email_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EmailField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>password_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PasswordField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>phone_number_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#phone_number_fields Wafv2WebAclRuleA#phone_number_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumberFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PhoneNumberFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>username_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UsernameField
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
