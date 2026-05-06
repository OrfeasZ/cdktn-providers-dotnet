using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters")]
    public class OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#display_name OpensearchOpensearchCluster#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#seed_cluster_id OpensearchOpensearchCluster#seed_cluster_id}.</summary>
        [JsiiProperty(name: "seedClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string SeedClusterId
        {
            get;
            set;
        }

        private object? _isSkipUnavailable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_skip_unavailable OpensearchOpensearchCluster#is_skip_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSkipUnavailable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSkipUnavailable
        {
            get => _isSkipUnavailable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isSkipUnavailable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#mode OpensearchOpensearchCluster#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#ping_schedule OpensearchOpensearchCluster#ping_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pingSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PingSchedule
        {
            get;
            set;
        }
    }
}
