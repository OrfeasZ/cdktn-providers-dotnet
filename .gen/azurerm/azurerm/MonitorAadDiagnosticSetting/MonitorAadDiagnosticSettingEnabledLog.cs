using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAadDiagnosticSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLog")]
    public class MonitorAadDiagnosticSettingEnabledLog : azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_aad_diagnostic_setting#category MonitorAadDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }
    }
}
