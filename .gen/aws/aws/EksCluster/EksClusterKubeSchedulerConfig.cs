using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeSchedulerConfig")]
    public class EksClusterKubeSchedulerConfig : aws.EksCluster.IEksClusterKubeSchedulerConfig
    {
        /// <summary>node_resources_fit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/eks_cluster#node_resources_fit EksCluster#node_resources_fit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeResourcesFit", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit? NodeResourcesFit
        {
            get;
            set;
        }
    }
}
