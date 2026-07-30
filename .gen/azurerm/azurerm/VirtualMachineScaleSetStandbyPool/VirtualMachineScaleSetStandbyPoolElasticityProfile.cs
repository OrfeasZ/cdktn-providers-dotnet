using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetStandbyPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachineScaleSetStandbyPool.VirtualMachineScaleSetStandbyPoolElasticityProfile")]
    public class VirtualMachineScaleSetStandbyPoolElasticityProfile : azurerm.VirtualMachineScaleSetStandbyPool.IVirtualMachineScaleSetStandbyPoolElasticityProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine_scale_set_standby_pool#max_ready_capacity VirtualMachineScaleSetStandbyPool#max_ready_capacity}.</summary>
        [JsiiProperty(name: "maxReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxReadyCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine_scale_set_standby_pool#min_ready_capacity VirtualMachineScaleSetStandbyPool#min_ready_capacity}.</summary>
        [JsiiProperty(name: "minReadyCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MinReadyCapacity
        {
            get;
            set;
        }
    }
}
