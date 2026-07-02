using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    [JsiiInterface(nativeType: typeof(IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails")]
    public interface IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#service_type ClusterPlacementGroupsClusterPlacementGroup#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#cluster_placement_group_count ClusterPlacementGroupsClusterPlacementGroup#cluster_placement_group_count}.</summary>
        [JsiiProperty(name: "clusterPlacementGroupCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClusterPlacementGroupCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#memory_in_gbs ClusterPlacementGroupsClusterPlacementGroup#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#nvmes ClusterPlacementGroupsClusterPlacementGroup#nvmes}.</summary>
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Nvmes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#ocpus ClusterPlacementGroupsClusterPlacementGroup#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#service_type ClusterPlacementGroupsClusterPlacementGroup#service_type}.</summary>
            [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#cluster_placement_group_count ClusterPlacementGroupsClusterPlacementGroup#cluster_placement_group_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterPlacementGroupCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClusterPlacementGroupCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#memory_in_gbs ClusterPlacementGroupsClusterPlacementGroup#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#nvmes ClusterPlacementGroupsClusterPlacementGroup#nvmes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Nvmes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/cluster_placement_groups_cluster_placement_group#ocpus ClusterPlacementGroupsClusterPlacementGroup#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
