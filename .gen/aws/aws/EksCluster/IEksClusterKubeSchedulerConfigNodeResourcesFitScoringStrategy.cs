using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy")]
    public interface IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy
    {
        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#resource EksCluster#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#type EksCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#resource EksCluster#resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Resource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#type EksCluster#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
