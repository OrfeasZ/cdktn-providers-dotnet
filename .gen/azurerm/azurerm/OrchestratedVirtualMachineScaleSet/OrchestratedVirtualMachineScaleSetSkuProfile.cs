using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfile")]
    public class OrchestratedVirtualMachineScaleSetSkuProfile : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/orchestrated_virtual_machine_scale_set#allocation_strategy OrchestratedVirtualMachineScaleSet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string AllocationStrategy
        {
            get;
            set;
        }

        private object? _virtualMachineSize;

        /// <summary>virtual_machine_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/orchestrated_virtual_machine_scale_set#virtual_machine_size OrchestratedVirtualMachineScaleSet#virtual_machine_size}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachineSize
        {
            get => _virtualMachineSize;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachineSize = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/orchestrated_virtual_machine_scale_set#vm_sizes OrchestratedVirtualMachineScaleSet#vm_sizes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmSizes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VmSizes
        {
            get;
            set;
        }
    }
}
