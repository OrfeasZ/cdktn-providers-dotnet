using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig")]
    public class EksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig : aws.EksCluster.IEksClusterKubeControllerManagerConfigHorizontalPodAutoscalerControllerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/eks_cluster#horizontal_pod_autoscaler_sync_period EksCluster#horizontal_pod_autoscaler_sync_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "horizontalPodAutoscalerSyncPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HorizontalPodAutoscalerSyncPeriod
        {
            get;
            set;
        }
    }
}
