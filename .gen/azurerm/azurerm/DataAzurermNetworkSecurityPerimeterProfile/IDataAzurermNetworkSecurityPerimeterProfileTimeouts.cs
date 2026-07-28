using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkSecurityPerimeterProfile
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkSecurityPerimeterProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkSecurityPerimeterProfile.DataAzurermNetworkSecurityPerimeterProfileTimeouts")]
    public interface IDataAzurermNetworkSecurityPerimeterProfileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/network_security_perimeter_profile#read DataAzurermNetworkSecurityPerimeterProfile#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkSecurityPerimeterProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkSecurityPerimeterProfile.DataAzurermNetworkSecurityPerimeterProfileTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkSecurityPerimeterProfile.IDataAzurermNetworkSecurityPerimeterProfileTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/network_security_perimeter_profile#read DataAzurermNetworkSecurityPerimeterProfile#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
