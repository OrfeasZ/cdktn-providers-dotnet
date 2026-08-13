using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeSchedulerConfigNodeResourcesFit), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit")]
    public interface IEksClusterKubeSchedulerConfigNodeResourcesFit
    {
        /// <summary>scoring_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#scoring_strategy EksCluster#scoring_strategy}
        /// </remarks>
        [JsiiProperty(name: "scoringStrategy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy? ScoringStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeSchedulerConfigNodeResourcesFit), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scoring_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#scoring_strategy EksCluster#scoring_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scoringStrategy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy? ScoringStrategy
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy?>();
            }
        }
    }
}
