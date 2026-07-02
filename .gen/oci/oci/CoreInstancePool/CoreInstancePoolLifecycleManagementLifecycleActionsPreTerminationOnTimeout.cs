using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout")]
    public class CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout : oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_instance_pool#preserve_block_volume_mode CoreInstancePool#preserve_block_volume_mode}.</summary>
        [JsiiProperty(name: "preserveBlockVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        public string PreserveBlockVolumeMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_instance_pool#preserve_boot_volume_mode CoreInstancePool#preserve_boot_volume_mode}.</summary>
        [JsiiProperty(name: "preserveBootVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        public string PreserveBootVolumeMode
        {
            get;
            set;
        }
    }
}
