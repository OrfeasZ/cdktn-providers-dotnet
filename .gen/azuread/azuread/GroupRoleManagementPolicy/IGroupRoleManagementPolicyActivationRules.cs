using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyActivationRules), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRules")]
    public interface IGroupRoleManagementPolicyActivationRules
    {
        /// <summary>approval_stage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approval_stage GroupRoleManagementPolicy#approval_stage}
        /// </remarks>
        [JsiiProperty(name: "approvalStage", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage? ApprovalStage
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time after which the an activation can be valid for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#maximum_duration GroupRoleManagementPolicy#maximum_duration}
        /// </remarks>
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether an approval is required for activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_approval GroupRoleManagementPolicy#require_approval}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireApproval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a conditional access context is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#required_conditional_access_authentication_context GroupRoleManagementPolicy#required_conditional_access_authentication_context}
        /// </remarks>
        [JsiiProperty(name: "requiredConditionalAccessAuthenticationContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequiredConditionalAccessAuthenticationContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a justification is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_justification GroupRoleManagementPolicy#require_justification}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireJustification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireJustification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether multi-factor authentication is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_multifactor_authentication GroupRoleManagementPolicy#require_multifactor_authentication}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireMultifactorAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether ticket information is required during activation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_ticket_info GroupRoleManagementPolicy#require_ticket_info}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireTicketInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireTicketInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyActivationRules), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRules")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>approval_stage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approval_stage GroupRoleManagementPolicy#approval_stage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalStage", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage? ApprovalStage
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage?>();
            }

            /// <summary>The time after which the an activation can be valid for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#maximum_duration GroupRoleManagementPolicy#maximum_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether an approval is required for activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_approval GroupRoleManagementPolicy#require_approval}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireApproval", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireApproval
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether a conditional access context is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#required_conditional_access_authentication_context GroupRoleManagementPolicy#required_conditional_access_authentication_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredConditionalAccessAuthenticationContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequiredConditionalAccessAuthenticationContext
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether a justification is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_justification GroupRoleManagementPolicy#require_justification}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireJustification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireJustification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether multi-factor authentication is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_multifactor_authentication GroupRoleManagementPolicy#require_multifactor_authentication}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireMultifactorAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireMultifactorAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether ticket information is required during activation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#require_ticket_info GroupRoleManagementPolicy#require_ticket_info}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireTicketInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireTicketInfo
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
