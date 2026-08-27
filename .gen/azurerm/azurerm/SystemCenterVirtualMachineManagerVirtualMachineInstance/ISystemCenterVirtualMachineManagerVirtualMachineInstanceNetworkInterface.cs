using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiInterface(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface")]
    public interface ISystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#name SystemCenterVirtualMachineManagerVirtualMachineInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#ipv4_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#ipv4_address_type}.</summary>
        [JsiiProperty(name: "ipv4AddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4AddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#ipv6_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#ipv6_address_type}.</summary>
        [JsiiProperty(name: "ipv6AddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6AddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#mac_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#mac_address_type}.</summary>
        [JsiiProperty(name: "macAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MacAddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#virtual_network_id SystemCenterVirtualMachineManagerVirtualMachineInstance#virtual_network_id}.</summary>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#name SystemCenterVirtualMachineManagerVirtualMachineInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#ipv4_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#ipv4_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4AddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv4AddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#ipv6_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#ipv6_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6AddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6AddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#mac_address_type SystemCenterVirtualMachineManagerVirtualMachineInstance#mac_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MacAddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#virtual_network_id SystemCenterVirtualMachineManagerVirtualMachineInstance#virtual_network_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
