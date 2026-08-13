using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit")]
    public class EksClusterKubeSchedulerConfigNodeResourcesFit : aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit
    {
        /// <summary>scoring_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#scoring_strategy EksCluster#scoring_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scoringStrategy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy? ScoringStrategy
        {
            get;
            set;
        }
    }
}
