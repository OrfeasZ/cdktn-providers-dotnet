using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy")]
    public class VirtualMachineScaleSetRollingUpgradePolicy : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#max_batch_instance_percent VirtualMachineScaleSet#max_batch_instance_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBatchInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBatchInstancePercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#max_unhealthy_instance_percent VirtualMachineScaleSet#max_unhealthy_instance_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyInstancePercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#max_unhealthy_upgraded_instance_percent VirtualMachineScaleSet#max_unhealthy_upgraded_instance_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyUpgradedInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyUpgradedInstancePercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#pause_time_between_batches VirtualMachineScaleSet#pause_time_between_batches}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pauseTimeBetweenBatches", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PauseTimeBetweenBatches
        {
            get;
            set;
        }
    }
}
