using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorDiagnosticSettingEnabledLog), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog")]
    public interface IMonitorDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Category
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category_group MonitorDiagnosticSetting#category_group}.</summary>
        [JsiiProperty(name: "categoryGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CategoryGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDiagnosticSettingEnabledLog), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Category
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_diagnostic_setting#category_group MonitorDiagnosticSetting#category_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "categoryGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CategoryGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
