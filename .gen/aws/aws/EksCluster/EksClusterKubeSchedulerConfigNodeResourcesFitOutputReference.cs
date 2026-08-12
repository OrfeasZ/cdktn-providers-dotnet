using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScoringStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}}]")]
        public virtual void PutScoringStrategy(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetScoringStrategy")]
        public virtual void ResetScoringStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scoringStrategy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference ScoringStrategy
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scoringStrategyInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy? ScoringStrategyInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit?>();
            set => SetInstanceProperty(value);
        }
    }
}
