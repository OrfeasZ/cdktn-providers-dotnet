using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackVirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackVirtualNetworkGatewayTimeouts), fullyQualifiedName: "azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayTimeouts")]
    public interface IDataAzurestackVirtualNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/virtual_network_gateway#read DataAzurestackVirtualNetworkGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackVirtualNetworkGatewayTimeouts), fullyQualifiedName: "azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackVirtualNetworkGateway.IDataAzurestackVirtualNetworkGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/virtual_network_gateway#read DataAzurestackVirtualNetworkGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
