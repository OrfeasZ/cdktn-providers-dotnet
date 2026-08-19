using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout")]
    public interface ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_instance_pool#preserve_block_volume_mode CoreInstancePool#preserve_block_volume_mode}.</summary>
        [JsiiProperty(name: "preserveBlockVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        string PreserveBlockVolumeMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_instance_pool#preserve_boot_volume_mode CoreInstancePool#preserve_boot_volume_mode}.</summary>
        [JsiiProperty(name: "preserveBootVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        string PreserveBootVolumeMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_instance_pool#preserve_block_volume_mode CoreInstancePool#preserve_block_volume_mode}.</summary>
            [JsiiProperty(name: "preserveBlockVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
            public string PreserveBlockVolumeMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_instance_pool#preserve_boot_volume_mode CoreInstancePool#preserve_boot_volume_mode}.</summary>
            [JsiiProperty(name: "preserveBootVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
            public string PreserveBootVolumeMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
