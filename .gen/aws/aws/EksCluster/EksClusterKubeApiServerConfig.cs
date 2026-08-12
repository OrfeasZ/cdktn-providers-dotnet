using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeApiServerConfig")]
    public class EksClusterKubeApiServerConfig : aws.EksCluster.IEksClusterKubeApiServerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#event_ttl EksCluster#event_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventTtl
        {
            get;
            set;
        }

        /// <summary>service_node_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#service_node_port_range EksCluster#service_node_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNodePortRange", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange? ServiceNodePortRange
        {
            get;
            set;
        }
    }
}
