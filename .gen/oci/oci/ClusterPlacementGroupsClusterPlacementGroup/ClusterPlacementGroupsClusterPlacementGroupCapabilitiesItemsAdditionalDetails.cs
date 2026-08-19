using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails")]
    public class ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails : oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cluster_placement_groups_cluster_placement_group#service_type ClusterPlacementGroupsClusterPlacementGroup#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cluster_placement_groups_cluster_placement_group#cluster_placement_group_count ClusterPlacementGroupsClusterPlacementGroup#cluster_placement_group_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClusterPlacementGroupCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cluster_placement_groups_cluster_placement_group#memory_in_gbs ClusterPlacementGroupsClusterPlacementGroup#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cluster_placement_groups_cluster_placement_group#nvmes ClusterPlacementGroupsClusterPlacementGroup#nvmes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Nvmes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cluster_placement_groups_cluster_placement_group#ocpus ClusterPlacementGroupsClusterPlacementGroup#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
