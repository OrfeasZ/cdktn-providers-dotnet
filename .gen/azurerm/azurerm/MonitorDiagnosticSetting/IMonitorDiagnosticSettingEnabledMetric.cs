using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorDiagnosticSettingEnabledMetric), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledMetric")]
    public interface IMonitorDiagnosticSettingEnabledMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        string Category
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDiagnosticSettingEnabledMetric), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledMetric")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
            public string Category
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
