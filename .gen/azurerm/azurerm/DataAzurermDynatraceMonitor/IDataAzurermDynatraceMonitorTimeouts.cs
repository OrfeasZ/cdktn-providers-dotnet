using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDynatraceMonitorTimeouts), fullyQualifiedName: "azurerm.dataAzurermDynatraceMonitor.DataAzurermDynatraceMonitorTimeouts")]
    public interface IDataAzurermDynatraceMonitorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dynatrace_monitor#read DataAzurermDynatraceMonitor#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDynatraceMonitorTimeouts), fullyQualifiedName: "azurerm.dataAzurermDynatraceMonitor.DataAzurermDynatraceMonitorTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDynatraceMonitor.IDataAzurermDynatraceMonitorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dynatrace_monitor#read DataAzurermDynatraceMonitor#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
