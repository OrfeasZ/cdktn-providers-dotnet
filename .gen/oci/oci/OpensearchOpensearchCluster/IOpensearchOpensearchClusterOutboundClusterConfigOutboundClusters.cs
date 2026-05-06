using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters")]
    public interface IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#display_name OpensearchOpensearchCluster#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#seed_cluster_id OpensearchOpensearchCluster#seed_cluster_id}.</summary>
        [JsiiProperty(name: "seedClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string SeedClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_skip_unavailable OpensearchOpensearchCluster#is_skip_unavailable}.</summary>
        [JsiiProperty(name: "isSkipUnavailable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSkipUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#mode OpensearchOpensearchCluster#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#ping_schedule OpensearchOpensearchCluster#ping_schedule}.</summary>
        [JsiiProperty(name: "pingSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PingSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#display_name OpensearchOpensearchCluster#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#seed_cluster_id OpensearchOpensearchCluster#seed_cluster_id}.</summary>
            [JsiiProperty(name: "seedClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string SeedClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_skip_unavailable OpensearchOpensearchCluster#is_skip_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSkipUnavailable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSkipUnavailable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#mode OpensearchOpensearchCluster#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#ping_schedule OpensearchOpensearchCluster#ping_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pingSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PingSchedule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
