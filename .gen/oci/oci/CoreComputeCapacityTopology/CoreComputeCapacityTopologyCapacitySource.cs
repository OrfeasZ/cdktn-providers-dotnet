using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityTopology
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreComputeCapacityTopology.CoreComputeCapacityTopologyCapacitySource")]
    public class CoreComputeCapacityTopologyCapacitySource : oci.CoreComputeCapacityTopology.ICoreComputeCapacityTopologyCapacitySource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#capacity_type CoreComputeCapacityTopology#capacity_type}.</summary>
        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_topology#compartment_id CoreComputeCapacityTopology#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }
    }
}
