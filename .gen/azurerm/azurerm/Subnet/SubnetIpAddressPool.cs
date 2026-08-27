using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subnet.SubnetIpAddressPool")]
    public class SubnetIpAddressPool : azurerm.Subnet.ISubnetIpAddressPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/subnet#id Subnet#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/subnet#number_of_ip_addresses Subnet#number_of_ip_addresses}.</summary>
        [JsiiProperty(name: "numberOfIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public string NumberOfIpAddresses
        {
            get;
            set;
        }
    }
}
