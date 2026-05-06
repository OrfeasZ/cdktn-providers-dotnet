using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction")]
    public class ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction : oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#type ClusterPlacementGroupsClusterPlacementGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#value ClusterPlacementGroupsClusterPlacementGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
