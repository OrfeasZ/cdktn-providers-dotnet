using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeControllerManagerConfigPodGcControllerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTerminatedPodGcThreshold")]
        public virtual void ResetTerminatedPodGcThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminatedPodGcThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TerminatedPodGcThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "terminatedPodGcThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TerminatedPodGcThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeControllerManagerConfigPodGcControllerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeControllerManagerConfigPodGcControllerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
