using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize")]
    public interface IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#name OrchestratedVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#rank OrchestratedVirtualMachineScaleSet#rank}.</summary>
        [JsiiProperty(name: "rank", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Rank
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetSkuProfileVirtualMachineSize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#name OrchestratedVirtualMachineScaleSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#rank OrchestratedVirtualMachineScaleSet#rank}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rank", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Rank
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
