using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledMetric")]
    public class MonitorDiagnosticSettingEnabledMetric : azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }
    }
}
