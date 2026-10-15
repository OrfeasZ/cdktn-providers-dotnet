using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterRemoteReindexTrustConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfig")]
    public interface IOpensearchOpensearchClusterRemoteReindexTrustConfig
    {
        /// <summary>remote_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#remote_sources OpensearchOpensearchCluster#remote_sources}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "remoteSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources\"},\"kind\":\"array\"}}]}}")]
        object RemoteSources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterRemoteReindexTrustConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>remote_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#remote_sources OpensearchOpensearchCluster#remote_sources}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "remoteSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources\"},\"kind\":\"array\"}}]}}")]
            public object RemoteSources
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
