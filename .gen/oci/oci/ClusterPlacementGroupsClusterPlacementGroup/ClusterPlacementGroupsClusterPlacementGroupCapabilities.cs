using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilities")]
    public class ClusterPlacementGroupsClusterPlacementGroupCapabilities : oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilities
    {
        private object _items;

        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#items ClusterPlacementGroupsClusterPlacementGroup#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems\"},\"kind\":\"array\"}}]}}")]
        public object Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }
    }
}
