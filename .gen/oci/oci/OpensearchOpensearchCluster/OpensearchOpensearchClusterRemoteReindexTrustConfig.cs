using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfig")]
    public class OpensearchOpensearchClusterRemoteReindexTrustConfig : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfig
    {
        private object _remoteSources;

        /// <summary>remote_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#remote_sources OpensearchOpensearchCluster#remote_sources}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "remoteSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources\"},\"kind\":\"array\"}}]}}")]
        public object RemoteSources
        {
            get => _remoteSources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _remoteSources = value;
            }
        }
    }
}
