using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagementWorkspace.DataAzurermApiManagementWorkspaceTimeouts")]
    public class DataAzurermApiManagementWorkspaceTimeouts : azurerm.DataAzurermApiManagementWorkspace.IDataAzurermApiManagementWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/api_management_workspace#read DataAzurermApiManagementWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
