using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeGpuMemoryFabric
{
    [JsiiInterface(nativeType: typeof(ICoreComputeGpuMemoryFabricMemoryFabricPreferences), fullyQualifiedName: "oci.coreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferences")]
    public interface ICoreComputeGpuMemoryFabricMemoryFabricPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_compute_gpu_memory_fabric#customer_desired_firmware_bundle_id CoreComputeGpuMemoryFabric#customer_desired_firmware_bundle_id}.</summary>
        [JsiiProperty(name: "customerDesiredFirmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerDesiredFirmwareBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_compute_gpu_memory_fabric#fabric_recycle_level CoreComputeGpuMemoryFabric#fabric_recycle_level}.</summary>
        [JsiiProperty(name: "fabricRecycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FabricRecycleLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeGpuMemoryFabricMemoryFabricPreferences), fullyQualifiedName: "oci.coreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferences")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeGpuMemoryFabric.ICoreComputeGpuMemoryFabricMemoryFabricPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_compute_gpu_memory_fabric#customer_desired_firmware_bundle_id CoreComputeGpuMemoryFabric#customer_desired_firmware_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerDesiredFirmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerDesiredFirmwareBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/core_compute_gpu_memory_fabric#fabric_recycle_level CoreComputeGpuMemoryFabric#fabric_recycle_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fabricRecycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FabricRecycleLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
