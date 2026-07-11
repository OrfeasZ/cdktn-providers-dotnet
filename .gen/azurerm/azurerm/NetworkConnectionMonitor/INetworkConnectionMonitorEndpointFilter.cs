using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiInterface(nativeType: typeof(INetworkConnectionMonitorEndpointFilter), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilter")]
    public interface INetworkConnectionMonitorEndpointFilter
    {
        /// <summary>item block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_connection_monitor#item NetworkConnectionMonitor#item}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilterItem" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "item", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilterItem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Item
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_connection_monitor#type NetworkConnectionMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkConnectionMonitorEndpointFilter), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>item block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_connection_monitor#item NetworkConnectionMonitor#item}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilterItem" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "item", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilterItem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Item
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_connection_monitor#type NetworkConnectionMonitor#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
