using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDynatraceMonitor
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDynatraceMonitor.DataAzurermDynatraceMonitorTimeouts")]
    public class DataAzurermDynatraceMonitorTimeouts : azurerm.DataAzurermDynatraceMonitor.IDataAzurermDynatraceMonitorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/dynatrace_monitor#read DataAzurermDynatraceMonitor#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
