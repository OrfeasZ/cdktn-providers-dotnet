using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityTopology
{
    [JsiiInterface(nativeType: typeof(ICoreComputeCapacityTopologyCapacitySource), fullyQualifiedName: "oci.coreComputeCapacityTopology.CoreComputeCapacityTopologyCapacitySource")]
    public interface ICoreComputeCapacityTopologyCapacitySource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#capacity_type CoreComputeCapacityTopology#capacity_type}.</summary>
        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#compartment_id CoreComputeCapacityTopology#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeCapacityTopologyCapacitySource), fullyQualifiedName: "oci.coreComputeCapacityTopology.CoreComputeCapacityTopologyCapacitySource")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeCapacityTopology.ICoreComputeCapacityTopologyCapacitySource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#capacity_type CoreComputeCapacityTopology#capacity_type}.</summary>
            [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#compartment_id CoreComputeCapacityTopology#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
