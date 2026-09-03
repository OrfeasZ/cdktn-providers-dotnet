using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiByValue(fqn: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog")]
    public class MonitorDiagnosticSettingEnabledLog : azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Category
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category_group MonitorDiagnosticSetting#category_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "categoryGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CategoryGroup
        {
            get;
            set;
        }
    }
}
