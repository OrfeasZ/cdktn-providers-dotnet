using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHorizontalPodAutoscalerSyncPeriod")]
        public virtual void ResetHorizontalPodAutoscalerSyncPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "horizontalPodAutoscalerSyncPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HorizontalPodAutoscalerSyncPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "horizontalPodAutoscalerSyncPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HorizontalPodAutoscalerSyncPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
