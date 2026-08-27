using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVpnServerConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationTimeouts")]
    public interface IDataAzurermVpnServerConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/vpn_server_configuration#read DataAzurermVpnServerConfiguration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVpnServerConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVpnServerConfiguration.IDataAzurermVpnServerConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/vpn_server_configuration#read DataAzurermVpnServerConfiguration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
