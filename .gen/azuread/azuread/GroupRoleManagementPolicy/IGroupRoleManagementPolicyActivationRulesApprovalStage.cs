using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyActivationRulesApprovalStage), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage")]
    public interface IGroupRoleManagementPolicyActivationRulesApprovalStage
    {
        /// <summary>primary_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#primary_approver GroupRoleManagementPolicy#primary_approver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
        object PrimaryApprover
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyActivationRulesApprovalStage), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>primary_approver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#primary_approver GroupRoleManagementPolicy#primary_approver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
            public object PrimaryApprover
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
