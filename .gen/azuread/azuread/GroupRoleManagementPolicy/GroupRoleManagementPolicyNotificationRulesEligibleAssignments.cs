using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignments")]
    public class GroupRoleManagementPolicyNotificationRulesEligibleAssignments : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications
        {
            get;
            set;
        }

        /// <summary>approver_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approver_notifications GroupRoleManagementPolicy#approver_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications
        {
            get;
            set;
        }

        /// <summary>assignee_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#assignee_notifications GroupRoleManagementPolicy#assignee_notifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications
        {
            get;
            set;
        }
    }
}
