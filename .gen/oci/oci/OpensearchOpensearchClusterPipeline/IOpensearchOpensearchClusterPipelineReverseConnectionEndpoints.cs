using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchClusterPipeline
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterPipelineReverseConnectionEndpoints), fullyQualifiedName: "oci.opensearchOpensearchClusterPipeline.OpensearchOpensearchClusterPipelineReverseConnectionEndpoints")]
    public interface IOpensearchOpensearchClusterPipelineReverseConnectionEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_fqdn OpensearchOpensearchClusterPipeline#customer_fqdn}.</summary>
        [JsiiProperty(name: "customerFqdn", typeJson: "{\"primitive\":\"string\"}")]
        string CustomerFqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_ip OpensearchOpensearchClusterPipeline#customer_ip}.</summary>
        [JsiiProperty(name: "customerIp", typeJson: "{\"primitive\":\"string\"}")]
        string CustomerIp
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterPipelineReverseConnectionEndpoints), fullyQualifiedName: "oci.opensearchOpensearchClusterPipeline.OpensearchOpensearchClusterPipelineReverseConnectionEndpoints")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchClusterPipeline.IOpensearchOpensearchClusterPipelineReverseConnectionEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_fqdn OpensearchOpensearchClusterPipeline#customer_fqdn}.</summary>
            [JsiiProperty(name: "customerFqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomerFqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster_pipeline#customer_ip OpensearchOpensearchClusterPipeline#customer_ip}.</summary>
            [JsiiProperty(name: "customerIp", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomerIp
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
