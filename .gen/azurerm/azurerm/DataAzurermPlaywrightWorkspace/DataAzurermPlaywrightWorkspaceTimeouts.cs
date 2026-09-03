using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPlaywrightWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPlaywrightWorkspace.DataAzurermPlaywrightWorkspaceTimeouts")]
    public class DataAzurermPlaywrightWorkspaceTimeouts : azurerm.DataAzurermPlaywrightWorkspace.IDataAzurermPlaywrightWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/playwright_workspace#read DataAzurermPlaywrightWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
