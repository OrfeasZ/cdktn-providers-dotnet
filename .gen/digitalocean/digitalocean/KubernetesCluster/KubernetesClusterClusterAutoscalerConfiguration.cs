using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    [JsiiByValue(fqn: "digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfiguration")]
    public class KubernetesClusterClusterAutoscalerConfiguration : digitalocean.KubernetesCluster.IKubernetesClusterClusterAutoscalerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#expanders KubernetesCluster#expanders}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expanders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Expanders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#scale_down_unneeded_time KubernetesCluster#scale_down_unneeded_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownUnneededTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#scale_down_utilization_threshold KubernetesCluster#scale_down_utilization_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleDownUtilizationThreshold
        {
            get;
            set;
        }
    }
}
