using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackLocalNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackLocalNetworkGatewayTimeouts), fullyQualifiedName: "azurestack.dataAzurestackLocalNetworkGateway.DataAzurestackLocalNetworkGatewayTimeouts")]
    public interface IDataAzurestackLocalNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/local_network_gateway#read DataAzurestackLocalNetworkGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackLocalNetworkGatewayTimeouts), fullyQualifiedName: "azurestack.dataAzurestackLocalNetworkGateway.DataAzurestackLocalNetworkGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackLocalNetworkGateway.IDataAzurestackLocalNetworkGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/local_network_gateway#read DataAzurestackLocalNetworkGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
