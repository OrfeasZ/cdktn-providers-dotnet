using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStage")]
    public class GroupRoleManagementPolicyActivationRulesApprovalStage : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStage
    {
        private object _primaryApprover;

        /// <summary>primary_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#primary_approver GroupRoleManagementPolicy#primary_approver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}")]
        public object PrimaryApprover
        {
            get => _primaryApprover;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyActivationRulesApprovalStagePrimaryApprover).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _primaryApprover = value;
            }
        }
    }
}
