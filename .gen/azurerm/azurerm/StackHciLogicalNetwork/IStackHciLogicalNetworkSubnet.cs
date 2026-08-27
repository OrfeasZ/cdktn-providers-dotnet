using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    [JsiiInterface(nativeType: typeof(IStackHciLogicalNetworkSubnet), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnet")]
    public interface IStackHciLogicalNetworkSubnet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#ip_allocation_method StackHciLogicalNetwork#ip_allocation_method}.</summary>
        [JsiiProperty(name: "ipAllocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        string IpAllocationMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AddressPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#ip_pool StackHciLogicalNetwork#ip_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#route StackHciLogicalNetwork#route}
        /// </remarks>
        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute? Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#vlan_id StackHciLogicalNetwork#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VlanId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciLogicalNetworkSubnet), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnet")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#ip_allocation_method StackHciLogicalNetwork#ip_allocation_method}.</summary>
            [JsiiProperty(name: "ipAllocationMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAllocationMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AddressPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ip_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#ip_pool StackHciLogicalNetwork#ip_pool}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpPool
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#route StackHciLogicalNetwork#route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute\"}", isOptional: true)]
            public azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute? Route
            {
                get => GetInstanceProperty<azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_logical_network#vlan_id StackHciLogicalNetwork#vlan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VlanId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
