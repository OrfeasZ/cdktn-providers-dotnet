using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
        string PayloadType
        {
            get;
        }

        /// <summary>address_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#address_fields Wafv2WebAclRuleA#address_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields" />)[]</para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#email_field Wafv2WebAclRuleA#email_field}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField" />)[]</para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField" />)[]</para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#phone_number_fields Wafv2WebAclRuleA#phone_number_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields" />)[]</para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField" />)[]</para>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#payload_type Wafv2WebAclRuleA#payload_type}.</summary>
            [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
            public string PayloadType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>address_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#address_fields Wafv2WebAclRuleA#address_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddressFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>email_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#email_field Wafv2WebAclRuleA#email_field}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EmailField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>password_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#password_field Wafv2WebAclRuleA#password_field}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PasswordField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>phone_number_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#phone_number_fields Wafv2WebAclRuleA#phone_number_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumberFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PhoneNumberFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>username_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/wafv2_web_acl_rule#username_field Wafv2WebAclRuleA#username_field}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField" />)[]</para>
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
