using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeSchedulerConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeSchedulerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeSchedulerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubeSchedulerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeSchedulerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNodeResourcesFit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}}]")]
        public virtual void PutNodeResourcesFit(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNodeResourcesFit")]
        public virtual void ResetNodeResourcesFit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nodeResourcesFit", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference NodeResourcesFit
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeResourcesFitInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFit\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit? NodeResourcesFitInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeSchedulerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
