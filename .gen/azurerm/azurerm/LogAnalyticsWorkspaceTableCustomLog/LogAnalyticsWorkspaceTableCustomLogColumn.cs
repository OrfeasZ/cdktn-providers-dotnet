using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogAnalyticsWorkspaceTableCustomLog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumn")]
    public class LogAnalyticsWorkspaceTableCustomLogColumn : azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/log_analytics_workspace_table_custom_log#name LogAnalyticsWorkspaceTableCustomLog#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/log_analytics_workspace_table_custom_log#type LogAnalyticsWorkspaceTableCustomLog#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/log_analytics_workspace_table_custom_log#description LogAnalyticsWorkspaceTableCustomLog#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/log_analytics_workspace_table_custom_log#display_name LogAnalyticsWorkspaceTableCustomLog#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
