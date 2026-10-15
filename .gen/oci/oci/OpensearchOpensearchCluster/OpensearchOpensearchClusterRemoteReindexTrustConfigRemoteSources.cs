using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources")]
    public class OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#certificate_id OpensearchOpensearchCluster#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#endpoint OpensearchOpensearchCluster#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#endpoint_resolution_ip OpensearchOpensearchCluster#endpoint_resolution_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointResolutionIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointResolutionIp
        {
            get;
            set;
        }
    }
}
