using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerIpamPoolStaticCidr
{
    [JsiiByValue(fqn: "azurerm.networkManagerIpamPoolStaticCidr.NetworkManagerIpamPoolStaticCidrTimeouts")]
    public class NetworkManagerIpamPoolStaticCidrTimeouts : azurerm.NetworkManagerIpamPoolStaticCidr.INetworkManagerIpamPoolStaticCidrTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_ipam_pool_static_cidr#create NetworkManagerIpamPoolStaticCidr#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_ipam_pool_static_cidr#delete NetworkManagerIpamPoolStaticCidr#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_ipam_pool_static_cidr#read NetworkManagerIpamPoolStaticCidr#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_ipam_pool_static_cidr#update NetworkManagerIpamPoolStaticCidr#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
