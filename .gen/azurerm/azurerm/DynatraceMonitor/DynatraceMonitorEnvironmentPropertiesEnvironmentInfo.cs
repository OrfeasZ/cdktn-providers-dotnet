using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo")]
    public class DynatraceMonitorEnvironmentPropertiesEnvironmentInfo : azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/dynatrace_monitor#environment_id DynatraceMonitor#environment_id}.</summary>
        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string EnvironmentId
        {
            get;
            set;
        }
    }
}
