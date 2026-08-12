using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeControllerManagerConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeControllerManagerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeControllerManagerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubeControllerManagerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeControllerManagerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHorizontalPodAutoscalerControllerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}}]")]
        public virtual void PutHorizontalPodAutoscalerControllerConfig(aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHorizontalPodAutoscalerControllerConfig")]
        public virtual void ResetHorizontalPodAutoscalerControllerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "horizontalPodAutoscalerControllerConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference HorizontalPodAutoscalerControllerConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "horizontalPodAutoscalerControllerConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig? HorizontalPodAutoscalerControllerConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeControllerManagerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeControllerManagerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
