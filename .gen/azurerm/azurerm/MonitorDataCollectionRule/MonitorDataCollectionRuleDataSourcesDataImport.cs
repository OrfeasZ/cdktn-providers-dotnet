using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport")]
    public class MonitorDataCollectionRuleDataSourcesDataImport : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport
    {
        private object _eventHubDataSource;

        /// <summary>event_hub_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_data_collection_rule#event_hub_data_source MonitorDataCollectionRule#event_hub_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "eventHubDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource\"},\"kind\":\"array\"}}]}}")]
        public object EventHubDataSource
        {
            get => _eventHubDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eventHubDataSource = value;
            }
        }
    }
}
