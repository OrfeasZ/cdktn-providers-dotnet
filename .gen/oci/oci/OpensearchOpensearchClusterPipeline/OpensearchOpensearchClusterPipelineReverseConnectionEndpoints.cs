using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchClusterPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchClusterPipeline.OpensearchOpensearchClusterPipelineReverseConnectionEndpoints")]
    public class OpensearchOpensearchClusterPipelineReverseConnectionEndpoints : oci.OpensearchOpensearchClusterPipeline.IOpensearchOpensearchClusterPipelineReverseConnectionEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_fqdn OpensearchOpensearchClusterPipeline#customer_fqdn}.</summary>
        [JsiiProperty(name: "customerFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomerFqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_ip OpensearchOpensearchClusterPipeline#customer_ip}.</summary>
        [JsiiProperty(name: "customerIp", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomerIp
        {
            get;
            set;
        }
    }
}
