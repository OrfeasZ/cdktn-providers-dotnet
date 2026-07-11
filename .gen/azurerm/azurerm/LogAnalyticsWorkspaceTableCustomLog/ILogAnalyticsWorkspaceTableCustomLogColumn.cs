using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogAnalyticsWorkspaceTableCustomLog
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsWorkspaceTableCustomLogColumn), fullyQualifiedName: "azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumn")]
    public interface ILogAnalyticsWorkspaceTableCustomLogColumn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#name LogAnalyticsWorkspaceTableCustomLog#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#type LogAnalyticsWorkspaceTableCustomLog#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#description LogAnalyticsWorkspaceTableCustomLog#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#display_name LogAnalyticsWorkspaceTableCustomLog#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsWorkspaceTableCustomLogColumn), fullyQualifiedName: "azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumn")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#name LogAnalyticsWorkspaceTableCustomLog#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#type LogAnalyticsWorkspaceTableCustomLog#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#description LogAnalyticsWorkspaceTableCustomLog#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/log_analytics_workspace_table_custom_log#display_name LogAnalyticsWorkspaceTableCustomLog#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
