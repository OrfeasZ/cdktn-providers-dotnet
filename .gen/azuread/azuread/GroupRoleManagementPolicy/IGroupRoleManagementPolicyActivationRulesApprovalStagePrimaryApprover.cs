using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover")]
    public interface IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover
    {
        /// <summary>The ID of the object to act as an approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#object_id GroupRoleManagementPolicy#object_id}
        /// </remarks>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectId
        {
            get;
        }

        /// <summary>The type of object acting as an approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#type GroupRoleManagementPolicy#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the object to act as an approver.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#object_id GroupRoleManagementPolicy#object_id}
            /// </remarks>
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of object acting as an approver.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#type GroupRoleManagementPolicy#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
