using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy")]
    public class EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy : aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy
    {
        private object? _resource;

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#resource EksCluster#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Resource
        {
            get => _resource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resource = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#type EksCluster#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
