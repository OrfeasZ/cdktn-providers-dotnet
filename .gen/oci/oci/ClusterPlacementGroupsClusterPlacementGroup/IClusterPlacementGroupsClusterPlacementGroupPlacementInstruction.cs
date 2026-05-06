using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    [JsiiInterface(nativeType: typeof(IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction")]
    public interface IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#type ClusterPlacementGroupsClusterPlacementGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#value ClusterPlacementGroupsClusterPlacementGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction")]
        internal sealed class _Proxy : DeputyBase, oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#type ClusterPlacementGroupsClusterPlacementGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#value ClusterPlacementGroupsClusterPlacementGroup#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
