using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroupRoleManagementPolicy
{
    [JsiiByValue(fqn: "azuread.dataAzureadGroupRoleManagementPolicy.DataAzureadGroupRoleManagementPolicyTimeouts")]
    public class DataAzureadGroupRoleManagementPolicyTimeouts : azuread.DataAzureadGroupRoleManagementPolicy.IDataAzureadGroupRoleManagementPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group_role_management_policy#read DataAzureadGroupRoleManagementPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
