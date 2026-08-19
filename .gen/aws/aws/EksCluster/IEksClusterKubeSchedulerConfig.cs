using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeSchedulerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfig")]
    public interface IEksClusterKubeSchedulerConfig
    {
        /// <summary>node_resources_fit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/eks_cluster#node_resources_fit EksCluster#node_resources_fit}
        /// </remarks>
        [JsiiProperty(name: "nodeResourcesFit", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit? NodeResourcesFit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeSchedulerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeSchedulerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>node_resources_fit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/eks_cluster#node_resources_fit EksCluster#node_resources_fit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeResourcesFit", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit? NodeResourcesFit
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit?>();
            }
        }
    }
}
