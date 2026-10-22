using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources")]
    public interface IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#ca_bundle_id OpensearchOpensearchCluster#ca_bundle_id}.</summary>
        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}")]
        string CaBundleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#certificate_id OpensearchOpensearchCluster#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#endpoint OpensearchOpensearchCluster#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#endpoint_resolution_ip OpensearchOpensearchCluster#endpoint_resolution_ip}.</summary>
        [JsiiProperty(name: "endpointResolutionIp", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointResolutionIp
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#ca_bundle_id OpensearchOpensearchCluster#ca_bundle_id}.</summary>
            [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string CaBundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#certificate_id OpensearchOpensearchCluster#certificate_id}.</summary>
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#endpoint OpensearchOpensearchCluster#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#endpoint_resolution_ip OpensearchOpensearchCluster#endpoint_resolution_ip}.</summary>
            [JsiiProperty(name: "endpointResolutionIp", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointResolutionIp
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
