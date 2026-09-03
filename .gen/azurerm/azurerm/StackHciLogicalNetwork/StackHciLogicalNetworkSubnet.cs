using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnet")]
    public class StackHciLogicalNetworkSubnet : azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#ip_allocation_method StackHciLogicalNetwork#ip_allocation_method}.</summary>
        [JsiiProperty(name: "ipAllocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string IpAllocationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressPrefix
        {
            get;
            set;
        }

        private object? _ipPool;

        /// <summary>ip_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#ip_pool StackHciLogicalNetwork#ip_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpPool
        {
            get => _ipPool;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipPool = value;
            }
        }

        /// <summary>route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#route StackHciLogicalNetwork#route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute\"}", isOptional: true)]
        public azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute? Route
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#vlan_id StackHciLogicalNetwork#vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VlanId
        {
            get;
            set;
        }
    }
}
