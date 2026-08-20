using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkManagerIpamPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkManagerIpamPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManagerIpamPool.DataAzurermNetworkManagerIpamPoolTimeouts")]
    public interface IDataAzurermNetworkManagerIpamPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/network_manager_ipam_pool#read DataAzurermNetworkManagerIpamPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkManagerIpamPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkManagerIpamPool.DataAzurermNetworkManagerIpamPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkManagerIpamPool.IDataAzurermNetworkManagerIpamPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/network_manager_ipam_pool#read DataAzurermNetworkManagerIpamPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
