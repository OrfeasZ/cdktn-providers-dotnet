using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeControllerManagerConfig")]
    public class EksClusterKubeControllerManagerConfig : aws.EksCluster.IEksClusterKubeControllerManagerConfig
    {
        /// <summary>horizontal_pod_autoscaler_controller_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_controller_config EksCluster#horizontal_pod_autoscaler_controller_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "horizontalPodAutoscalerControllerConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig? HorizontalPodAutoscalerControllerConfig
        {
            get;
            set;
        }

        /// <summary>pod_gc_controller_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#pod_gc_controller_config EksCluster#pod_gc_controller_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podGcControllerConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfig\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubeControllerManagerConfigPodGcControllerConfig? PodGcControllerConfig
        {
            get;
            set;
        }
    }
}
