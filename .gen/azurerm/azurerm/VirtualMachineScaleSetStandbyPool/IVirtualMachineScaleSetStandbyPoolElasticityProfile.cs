using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetStandbyPool
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetStandbyPoolElasticityProfile), fullyQualifiedName: "azurerm.virtualMachineScaleSetStandbyPool.VirtualMachineScaleSetStandbyPoolElasticityProfile")]
    public interface IVirtualMachineScaleSetStandbyPoolElasticityProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/virtual_machine_scale_set_standby_pool#max_ready_capacity VirtualMachineScaleSetStandbyPool#max_ready_capacity}.</summary>
        [JsiiProperty(name: "maxReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MaxReadyCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/virtual_machine_scale_set_standby_pool#min_ready_capacity VirtualMachineScaleSetStandbyPool#min_ready_capacity}.</summary>
        [JsiiProperty(name: "minReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MinReadyCapacity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetStandbyPoolElasticityProfile), fullyQualifiedName: "azurerm.virtualMachineScaleSetStandbyPool.VirtualMachineScaleSetStandbyPoolElasticityProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSetStandbyPool.IVirtualMachineScaleSetStandbyPoolElasticityProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/virtual_machine_scale_set_standby_pool#max_ready_capacity VirtualMachineScaleSetStandbyPool#max_ready_capacity}.</summary>
            [JsiiProperty(name: "maxReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxReadyCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/virtual_machine_scale_set_standby_pool#min_ready_capacity VirtualMachineScaleSetStandbyPool#min_ready_capacity}.</summary>
            [JsiiProperty(name: "minReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MinReadyCapacity
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
