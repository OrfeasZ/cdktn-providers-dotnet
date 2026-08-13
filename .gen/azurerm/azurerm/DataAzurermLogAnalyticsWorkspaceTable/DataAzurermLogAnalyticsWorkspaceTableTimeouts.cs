using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogAnalyticsWorkspaceTable
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLogAnalyticsWorkspaceTable.DataAzurermLogAnalyticsWorkspaceTableTimeouts")]
    public class DataAzurermLogAnalyticsWorkspaceTableTimeouts : azurerm.DataAzurermLogAnalyticsWorkspaceTable.IDataAzurermLogAnalyticsWorkspaceTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/log_analytics_workspace_table#read DataAzurermLogAnalyticsWorkspaceTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
