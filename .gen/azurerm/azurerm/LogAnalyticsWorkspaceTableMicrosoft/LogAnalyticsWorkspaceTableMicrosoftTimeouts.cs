using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogAnalyticsWorkspaceTableMicrosoft
{
    [JsiiByValue(fqn: "azurerm.logAnalyticsWorkspaceTableMicrosoft.LogAnalyticsWorkspaceTableMicrosoftTimeouts")]
    public class LogAnalyticsWorkspaceTableMicrosoftTimeouts : azurerm.LogAnalyticsWorkspaceTableMicrosoft.ILogAnalyticsWorkspaceTableMicrosoftTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/log_analytics_workspace_table_microsoft#create LogAnalyticsWorkspaceTableMicrosoft#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/log_analytics_workspace_table_microsoft#delete LogAnalyticsWorkspaceTableMicrosoft#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/log_analytics_workspace_table_microsoft#read LogAnalyticsWorkspaceTableMicrosoft#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/log_analytics_workspace_table_microsoft#update LogAnalyticsWorkspaceTableMicrosoft#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
