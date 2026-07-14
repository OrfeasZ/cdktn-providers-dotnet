using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IOrchestratedVirtualMachineScaleSetSkuProfile), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfile")]
    public interface IOrchestratedVirtualMachineScaleSetSkuProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#allocation_strategy OrchestratedVirtualMachineScaleSet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        /// <summary>virtual_machine_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#virtual_machine_size OrchestratedVirtualMachineScaleSet#virtual_machine_size}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualMachineSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#vm_sizes OrchestratedVirtualMachineScaleSet#vm_sizes}.</summary>
        [JsiiProperty(name: "vmSizes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VmSizes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrchestratedVirtualMachineScaleSetSkuProfile), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#allocation_strategy OrchestratedVirtualMachineScaleSet#allocation_strategy}.</summary>
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>virtual_machine_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#virtual_machine_size OrchestratedVirtualMachineScaleSet#virtual_machine_size}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualMachineSize
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#vm_sizes OrchestratedVirtualMachineScaleSet#vm_sizes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmSizes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VmSizes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
