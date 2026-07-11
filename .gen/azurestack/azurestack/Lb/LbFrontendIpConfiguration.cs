using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Lb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.lb.LbFrontendIpConfiguration")]
    public class LbFrontendIpConfiguration : azurestack.Lb.ILbFrontendIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/lb#name Lb#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/lb#private_ip_address Lb#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/lb#private_ip_address_allocation Lb#private_ip_address_allocation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressAllocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddressAllocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/lb#public_ip_address_id Lb#public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/lb#subnet_id Lb#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
