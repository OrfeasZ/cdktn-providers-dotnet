using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanKubernetesCluster
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration")]
    public class DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration : digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#expanders DataDigitaloceanKubernetesCluster#expanders}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expanders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Expanders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_unneeded_time DataDigitaloceanKubernetesCluster#scale_down_unneeded_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownUnneededTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_utilization_threshold DataDigitaloceanKubernetesCluster#scale_down_utilization_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleDownUtilizationThreshold
        {
            get;
            set;
        }
    }
}
