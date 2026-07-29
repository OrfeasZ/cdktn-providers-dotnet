using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeGpuMemoryFabric
{
    [JsiiByValue(fqn: "oci.coreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferences")]
    public class CoreComputeGpuMemoryFabricMemoryFabricPreferences : oci.CoreComputeGpuMemoryFabric.ICoreComputeGpuMemoryFabricMemoryFabricPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_compute_gpu_memory_fabric#customer_desired_firmware_bundle_id CoreComputeGpuMemoryFabric#customer_desired_firmware_bundle_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerDesiredFirmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerDesiredFirmwareBundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_compute_gpu_memory_fabric#fabric_recycle_level CoreComputeGpuMemoryFabric#fabric_recycle_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fabricRecycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FabricRecycleLevel
        {
            get;
            set;
        }
    }
}
