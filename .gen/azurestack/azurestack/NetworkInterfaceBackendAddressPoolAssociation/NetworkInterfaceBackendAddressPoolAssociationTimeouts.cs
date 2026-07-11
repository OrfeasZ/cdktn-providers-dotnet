using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.NetworkInterfaceBackendAddressPoolAssociation
{
    [JsiiByValue(fqn: "azurestack.networkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeouts")]
    public class NetworkInterfaceBackendAddressPoolAssociationTimeouts : azurestack.NetworkInterfaceBackendAddressPoolAssociation.INetworkInterfaceBackendAddressPoolAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association#create NetworkInterfaceBackendAddressPoolAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association#delete NetworkInterfaceBackendAddressPoolAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association#read NetworkInterfaceBackendAddressPoolAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/network_interface_backend_address_pool_association#update NetworkInterfaceBackendAddressPoolAssociation#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
