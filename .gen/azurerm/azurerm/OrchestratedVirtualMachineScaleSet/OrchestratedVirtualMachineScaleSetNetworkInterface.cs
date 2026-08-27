using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetNetworkInterface")]
    public class OrchestratedVirtualMachineScaleSetNetworkInterface : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetNetworkInterface
    {
        private object _ipConfiguration;

        /// <summary>ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#ip_configuration OrchestratedVirtualMachineScaleSet#ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetNetworkInterfaceIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetNetworkInterfaceIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        public object IpConfiguration
        {
            get => _ipConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetNetworkInterfaceIpConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetNetworkInterfaceIpConfiguration).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetNetworkInterfaceIpConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#name OrchestratedVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _acceleratedNetworkingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#accelerated_networking_enabled OrchestratedVirtualMachineScaleSet#accelerated_networking_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratedNetworkingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceleratedNetworkingEnabled
        {
            get => _acceleratedNetworkingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _acceleratedNetworkingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#auxiliary_mode OrchestratedVirtualMachineScaleSet#auxiliary_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auxiliaryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuxiliaryMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#auxiliary_sku OrchestratedVirtualMachineScaleSet#auxiliary_sku}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auxiliarySku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuxiliarySku
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#dns_servers OrchestratedVirtualMachineScaleSet#dns_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsServers
        {
            get;
            set;
        }

        private object? _ipForwardingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#ip_forwarding_enabled OrchestratedVirtualMachineScaleSet#ip_forwarding_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipForwardingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IpForwardingEnabled
        {
            get => _ipForwardingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipForwardingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#network_security_group_id OrchestratedVirtualMachineScaleSet#network_security_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkSecurityGroupId
        {
            get;
            set;
        }

        private object? _primary;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#primary OrchestratedVirtualMachineScaleSet#primary}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Primary
        {
            get => _primary;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _primary = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/orchestrated_virtual_machine_scale_set#tags OrchestratedVirtualMachineScaleSet#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
