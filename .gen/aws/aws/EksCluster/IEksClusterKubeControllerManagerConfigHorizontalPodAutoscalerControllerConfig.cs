using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig")]
    public interface IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_sync_period EksCluster#horizontal_pod_autoscaler_sync_period}.</summary>
        [JsiiProperty(name: "horizontalPodAutoscalerSyncPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HorizontalPodAutoscalerSyncPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_sync_period EksCluster#horizontal_pod_autoscaler_sync_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "horizontalPodAutoscalerSyncPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HorizontalPodAutoscalerSyncPeriod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
