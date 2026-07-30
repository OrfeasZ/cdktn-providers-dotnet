using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkSecurityPerimeter
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkSecurityPerimeterTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkSecurityPerimeter.DataAzurermNetworkSecurityPerimeterTimeouts")]
    public interface IDataAzurermNetworkSecurityPerimeterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_security_perimeter#read DataAzurermNetworkSecurityPerimeter#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkSecurityPerimeterTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkSecurityPerimeter.DataAzurermNetworkSecurityPerimeterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkSecurityPerimeter.IDataAzurermNetworkSecurityPerimeterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_security_perimeter#read DataAzurermNetworkSecurityPerimeter#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
