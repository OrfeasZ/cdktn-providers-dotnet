using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings")]
    public class KubernetesClusterDefaultNodePoolUpgradeSettings : azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#max_surge KubernetesCluster#max_surge}.</summary>
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}")]
        public string MaxSurge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#drain_timeout_in_minutes KubernetesCluster#drain_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#node_soak_duration_in_minutes KubernetesCluster#node_soak_duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NodeSoakDurationInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/kubernetes_cluster#undrainable_node_behavior KubernetesCluster#undrainable_node_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "undrainableNodeBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UndrainableNodeBehavior
        {
            get;
            set;
        }
    }
}
