using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiByValue(fqn: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolUpgradeSettings")]
    public class KubernetesClusterNodePoolUpgradeSettings : azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolUpgradeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#drain_timeout_in_minutes KubernetesClusterNodePool#drain_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_surge KubernetesClusterNodePool#max_surge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxSurge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#max_unavailable KubernetesClusterNodePool#max_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxUnavailable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#node_soak_duration_in_minutes KubernetesClusterNodePool#node_soak_duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NodeSoakDurationInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster_node_pool#undrainable_node_behavior KubernetesClusterNodePool#undrainable_node_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "undrainableNodeBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UndrainableNodeBehavior
        {
            get;
            set;
        }
    }
}
