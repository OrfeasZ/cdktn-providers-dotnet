using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanKubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration), fullyQualifiedName: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration")]
    public interface IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#expanders DataDigitaloceanKubernetesCluster#expanders}.</summary>
        [JsiiProperty(name: "expanders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Expanders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_unneeded_time DataDigitaloceanKubernetesCluster#scale_down_unneeded_time}.</summary>
        [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownUnneededTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_utilization_threshold DataDigitaloceanKubernetesCluster#scale_down_utilization_threshold}.</summary>
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleDownUtilizationThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration), fullyQualifiedName: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#expanders DataDigitaloceanKubernetesCluster#expanders}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expanders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Expanders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_unneeded_time DataDigitaloceanKubernetesCluster#scale_down_unneeded_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownUnneededTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#scale_down_utilization_threshold DataDigitaloceanKubernetesCluster#scale_down_utilization_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleDownUtilizationThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
