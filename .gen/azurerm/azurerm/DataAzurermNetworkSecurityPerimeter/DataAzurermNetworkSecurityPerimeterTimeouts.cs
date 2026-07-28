using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkSecurityPerimeter
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkSecurityPerimeter.DataAzurermNetworkSecurityPerimeterTimeouts")]
    public class DataAzurermNetworkSecurityPerimeterTimeouts : azurerm.DataAzurermNetworkSecurityPerimeter.IDataAzurermNetworkSecurityPerimeterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/network_security_perimeter#read DataAzurermNetworkSecurityPerimeter#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
