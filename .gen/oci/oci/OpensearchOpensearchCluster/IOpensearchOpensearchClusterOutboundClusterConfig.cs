using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterOutboundClusterConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig")]
    public interface IOpensearchOpensearchClusterOutboundClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_enabled OpensearchOpensearchCluster#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>outbound_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#outbound_clusters OpensearchOpensearchCluster#outbound_clusters}
        /// </remarks>
        [JsiiProperty(name: "outboundClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters\"},\"kind\":\"array\"}}]}}")]
        object OutboundClusters
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterOutboundClusterConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_enabled OpensearchOpensearchCluster#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>outbound_clusters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#outbound_clusters OpensearchOpensearchCluster#outbound_clusters}
            /// </remarks>
            [JsiiProperty(name: "outboundClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters\"},\"kind\":\"array\"}}]}}")]
            public object OutboundClusters
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
