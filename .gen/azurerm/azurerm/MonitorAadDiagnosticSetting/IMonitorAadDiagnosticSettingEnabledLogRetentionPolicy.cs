using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAadDiagnosticSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy), fullyQualifiedName: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLogRetentionPolicy")]
    public interface IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_aad_diagnostic_setting#days MonitorAadDiagnosticSetting#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_aad_diagnostic_setting#enabled MonitorAadDiagnosticSetting#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy), fullyQualifiedName: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLogRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_aad_diagnostic_setting#days MonitorAadDiagnosticSetting#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_aad_diagnostic_setting#enabled MonitorAadDiagnosticSetting#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
