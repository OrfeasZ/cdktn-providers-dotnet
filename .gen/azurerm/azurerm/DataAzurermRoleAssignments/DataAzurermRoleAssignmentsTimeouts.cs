using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRoleAssignments
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRoleAssignments.DataAzurermRoleAssignmentsTimeouts")]
    public class DataAzurermRoleAssignmentsTimeouts : azurerm.DataAzurermRoleAssignments.IDataAzurermRoleAssignmentsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/role_assignments#read DataAzurermRoleAssignments#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
