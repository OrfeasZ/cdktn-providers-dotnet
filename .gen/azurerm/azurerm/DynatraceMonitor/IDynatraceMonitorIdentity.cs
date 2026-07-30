using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDynatraceMonitorIdentity), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorIdentity")]
    public interface IDynatraceMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/dynatrace_monitor#type DynatraceMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceMonitorIdentity), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceMonitor.IDynatraceMonitorIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/dynatrace_monitor#type DynatraceMonitor#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
