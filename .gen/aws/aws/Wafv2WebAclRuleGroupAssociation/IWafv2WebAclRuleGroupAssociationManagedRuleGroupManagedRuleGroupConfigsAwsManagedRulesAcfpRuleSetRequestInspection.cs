using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection")]
    public interface IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
    {
        /// <summary>Payload type for inspection, either JSON or FORM_ENCODED.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#payload_type Wafv2WebAclRuleGroupAssociation#payload_type}
        /// </remarks>
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
        string PayloadType
        {
            get;
        }

        /// <summary>address_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#address_fields Wafv2WebAclRuleGroupAssociation#address_fields}
        /// </remarks>
        [JsiiProperty(name: "addressFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#email_field Wafv2WebAclRuleGroupAssociation#email_field}
        /// </remarks>
        [JsiiProperty(name: "emailField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#password_field Wafv2WebAclRuleGroupAssociation#password_field}
        /// </remarks>
        [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#phone_number_fields Wafv2WebAclRuleGroupAssociation#phone_number_fields}
        /// </remarks>
        [JsiiProperty(name: "phoneNumberFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#username_field Wafv2WebAclRuleGroupAssociation#username_field}
        /// </remarks>
        [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UsernameField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Payload type for inspection, either JSON or FORM_ENCODED.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#payload_type Wafv2WebAclRuleGroupAssociation#payload_type}
            /// </remarks>
            [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}")]
            public string PayloadType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>address_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#address_fields Wafv2WebAclRuleGroupAssociation#address_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddressFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>email_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#email_field Wafv2WebAclRuleGroupAssociation#email_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EmailField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>password_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#password_field Wafv2WebAclRuleGroupAssociation#password_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PasswordField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>phone_number_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#phone_number_fields Wafv2WebAclRuleGroupAssociation#phone_number_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumberFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PhoneNumberFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>username_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#username_field Wafv2WebAclRuleGroupAssociation#username_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usernameField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UsernameField
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
