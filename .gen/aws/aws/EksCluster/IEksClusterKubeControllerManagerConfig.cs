using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeControllerManagerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfig")]
    public interface IEksClusterKubeControllerManagerConfig
    {
        /// <summary>horizontal_pod_autoscaler_controller_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_controller_config EksCluster#horizontal_pod_autoscaler_controller_config}
        /// </remarks>
        [JsiiProperty(name: "horizontalPodAutoscalerControllerConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig? HorizontalPodAutoscalerControllerConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeControllerManagerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeControllerManagerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>horizontal_pod_autoscaler_controller_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_controller_config EksCluster#horizontal_pod_autoscaler_controller_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "horizontalPodAutoscalerControllerConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig? HorizontalPodAutoscalerControllerConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig?>();
            }
        }
    }
}
