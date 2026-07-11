using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesEligibleActivations), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations")]
    public interface IGroupRoleManagementPolicyNotificationRulesEligibleActivations
    {
        /// <summary>admin_notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
        /// </remarks>
        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications
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
        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications
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
        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyNotificationRulesEligibleActivations), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>admin_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#admin_notifications GroupRoleManagementPolicy#admin_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications?>();
            }

            /// <summary>approver_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#approver_notifications GroupRoleManagementPolicy#approver_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications?>();
            }

            /// <summary>assignee_notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#assignee_notifications GroupRoleManagementPolicy#assignee_notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications\"}", isOptional: true)]
            public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications
            {
                get => GetInstanceProperty<azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotifications?>();
            }
        }
    }
}
