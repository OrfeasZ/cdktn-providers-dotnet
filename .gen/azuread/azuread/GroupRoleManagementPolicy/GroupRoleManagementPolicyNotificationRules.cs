using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRules")]
    public class GroupRoleManagementPolicyNotificationRules : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRules
    {
        /// <summary>active_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#active_assignments GroupRoleManagementPolicy#active_assignments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignments
        {
            get;
            set;
        }

        /// <summary>eligible_activations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#eligible_activations GroupRoleManagementPolicy#eligible_activations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivations
        {
            get;
            set;
        }

        /// <summary>eligible_assignments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#eligible_assignments GroupRoleManagementPolicy#eligible_assignments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignments
        {
            get;
            set;
        }
    }
}
