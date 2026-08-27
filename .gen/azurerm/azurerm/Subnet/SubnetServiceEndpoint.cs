using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subnet.SubnetServiceEndpoint")]
    public class SubnetServiceEndpoint : azurerm.Subnet.ISubnetServiceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/subnet#service Subnet#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/subnet#network_identifier Subnet#network_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkIdentifier
        {
            get;
            set;
        }
    }
}
