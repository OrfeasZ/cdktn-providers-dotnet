using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments")]
    public class GroupRoleManagementPolicyNotificationRulesActiveAssignments : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications
        {
            get;
            set;
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approver_notifications GroupRoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications
        {
            get;
            set;
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#assignee_notifications GroupRoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications
        {
            get;
            set;
        }
    }
}
