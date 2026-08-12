using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreComputeCluster.CoreComputeClusterPlacementConstraintDetails")]
    public class CoreComputeClusterPlacementConstraintDetails : oci.CoreComputeCluster.ICoreComputeClusterPlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#type CoreComputeCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#hpc_island_id CoreComputeCluster#hpc_island_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HpcIslandId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#logical_placement_constraint CoreComputeCluster#logical_placement_constraint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logicalPlacementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogicalPlacementConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_memory_fabric_ids CoreComputeCluster#target_memory_fabric_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryFabricIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetMemoryFabricIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_network_block_ids CoreComputeCluster#target_network_block_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetNetworkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetNetworkBlockIds
        {
            get;
            set;
        }
    }
}
