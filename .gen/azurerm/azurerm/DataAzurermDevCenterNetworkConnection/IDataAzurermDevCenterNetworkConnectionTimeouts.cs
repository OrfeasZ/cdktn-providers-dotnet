using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterNetworkConnection
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterNetworkConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterNetworkConnection.DataAzurermDevCenterNetworkConnectionTimeouts")]
    public interface IDataAzurermDevCenterNetworkConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/dev_center_network_connection#read DataAzurermDevCenterNetworkConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterNetworkConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterNetworkConnection.DataAzurermDevCenterNetworkConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterNetworkConnection.IDataAzurermDevCenterNetworkConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/dev_center_network_connection#read DataAzurermDevCenterNetworkConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
