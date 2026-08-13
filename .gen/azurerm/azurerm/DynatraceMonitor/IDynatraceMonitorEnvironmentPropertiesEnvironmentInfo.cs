using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo")]
    public interface IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/dynatrace_monitor#environment_id DynatraceMonitor#environment_id}.</summary>
        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/dynatrace_monitor#environment_id DynatraceMonitor#environment_id}.</summary>
            [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
