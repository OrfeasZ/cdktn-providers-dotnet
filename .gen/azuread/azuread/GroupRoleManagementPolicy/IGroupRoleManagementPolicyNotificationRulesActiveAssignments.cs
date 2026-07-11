using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesActiveAssignments), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments")]
    public interface IGroupRoleManagementPolicyNotificationRulesActiveAssignments
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approver_notifications GroupRoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#assignee_notifications GroupRoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesActiveAssignments), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>admin_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications?>();
            }

            /// <summary>approver_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approver_notifications GroupRoleManagementPolicy#approver_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications?>();
            }

            /// <summary>assignee_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#assignee_notifications GroupRoleManagementPolicy#assignee_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications?>();
            }
        }
    }
}
