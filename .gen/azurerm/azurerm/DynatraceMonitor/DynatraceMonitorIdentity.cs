using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dynatraceMonitor.DynatraceMonitorIdentity")]
    public class DynatraceMonitorIdentity : azurerm.DynatraceMonitor.IDynatraceMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/dynatrace_monitor#type DynatraceMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
