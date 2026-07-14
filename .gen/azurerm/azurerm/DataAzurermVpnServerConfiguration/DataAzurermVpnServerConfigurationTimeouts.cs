using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVpnServerConfiguration
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationTimeouts")]
    public class DataAzurermVpnServerConfigurationTimeouts : azurerm.DataAzurermVpnServerConfiguration.IDataAzurermVpnServerConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/vpn_server_configuration#read DataAzurermVpnServerConfiguration#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
