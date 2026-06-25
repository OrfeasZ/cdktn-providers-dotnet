using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems")]
    public class ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems : oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cluster_placement_groups_cluster_placement_group#name ClusterPlacementGroupsClusterPlacementGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cluster_placement_groups_cluster_placement_group#service ClusterPlacementGroupsClusterPlacementGroup#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }

        /// <summary>additional_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cluster_placement_groups_cluster_placement_group#additional_details ClusterPlacementGroupsClusterPlacementGroup#additional_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails\"}", isOptional: true)]
        public oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails? AdditionalDetails
        {
            get;
            set;
        }
    }
}
