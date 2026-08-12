using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCluster
{
    [JsiiInterface(nativeType: typeof(ICoreComputeClusterPlacementConstraintDetails), fullyQualifiedName: "oci.coreComputeCluster.CoreComputeClusterPlacementConstraintDetails")]
    public interface ICoreComputeClusterPlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#type CoreComputeCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#hpc_island_id CoreComputeCluster#hpc_island_id}.</summary>
        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HpcIslandId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#logical_placement_constraint CoreComputeCluster#logical_placement_constraint}.</summary>
        [JsiiProperty(name: "logicalPlacementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogicalPlacementConstraint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_memory_fabric_ids CoreComputeCluster#target_memory_fabric_ids}.</summary>
        [JsiiProperty(name: "targetMemoryFabricIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetMemoryFabricIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_network_block_ids CoreComputeCluster#target_network_block_ids}.</summary>
        [JsiiProperty(name: "targetNetworkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetNetworkBlockIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeClusterPlacementConstraintDetails), fullyQualifiedName: "oci.coreComputeCluster.CoreComputeClusterPlacementConstraintDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeCluster.ICoreComputeClusterPlacementConstraintDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#type CoreComputeCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#hpc_island_id CoreComputeCluster#hpc_island_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HpcIslandId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#logical_placement_constraint CoreComputeCluster#logical_placement_constraint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logicalPlacementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogicalPlacementConstraint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_memory_fabric_ids CoreComputeCluster#target_memory_fabric_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetMemoryFabricIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetMemoryFabricIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_cluster#target_network_block_ids CoreComputeCluster#target_network_block_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetNetworkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetNetworkBlockIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
