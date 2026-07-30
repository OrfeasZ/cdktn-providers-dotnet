using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkSecurityPerimeterProfile
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkSecurityPerimeterProfile.DataAzurermNetworkSecurityPerimeterProfileTimeouts")]
    public class DataAzurermNetworkSecurityPerimeterProfileTimeouts : azurerm.DataAzurermNetworkSecurityPerimeterProfile.IDataAzurermNetworkSecurityPerimeterProfileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/network_security_perimeter_profile#read DataAzurermNetworkSecurityPerimeterProfile#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
