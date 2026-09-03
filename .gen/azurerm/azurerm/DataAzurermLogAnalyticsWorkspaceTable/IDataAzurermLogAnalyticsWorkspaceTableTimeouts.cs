using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogAnalyticsWorkspaceTable
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLogAnalyticsWorkspaceTableTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogAnalyticsWorkspaceTable.DataAzurermLogAnalyticsWorkspaceTableTimeouts")]
    public interface IDataAzurermLogAnalyticsWorkspaceTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/log_analytics_workspace_table#read DataAzurermLogAnalyticsWorkspaceTable#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLogAnalyticsWorkspaceTableTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogAnalyticsWorkspaceTable.DataAzurermLogAnalyticsWorkspaceTableTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLogAnalyticsWorkspaceTable.IDataAzurermLogAnalyticsWorkspaceTableTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/log_analytics_workspace_table#read DataAzurermLogAnalyticsWorkspaceTable#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
