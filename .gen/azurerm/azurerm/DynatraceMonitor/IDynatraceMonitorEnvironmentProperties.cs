using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDynatraceMonitorEnvironmentProperties), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentProperties")]
    public interface IDynatraceMonitorEnvironmentProperties
    {
        /// <summary>environment_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_monitor#environment_info DynatraceMonitor#environment_info}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "environmentInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo\"},\"kind\":\"array\"}}]}}")]
        object EnvironmentInfo
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceMonitorEnvironmentProperties), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>environment_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_monitor#environment_info DynatraceMonitor#environment_info}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "environmentInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo\"},\"kind\":\"array\"}}]}}")]
            public object EnvironmentInfo
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
