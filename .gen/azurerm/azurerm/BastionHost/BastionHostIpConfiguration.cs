using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BastionHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.bastionHost.BastionHostIpConfiguration")]
    public class BastionHostIpConfiguration : azurerm.BastionHost.IBastionHostIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/bastion_host#name BastionHost#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/bastion_host#subnet_id BastionHost#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/bastion_host#public_ip_address_id BastionHost#public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIpAddressId
        {
            get;
            set;
        }
    }
}
