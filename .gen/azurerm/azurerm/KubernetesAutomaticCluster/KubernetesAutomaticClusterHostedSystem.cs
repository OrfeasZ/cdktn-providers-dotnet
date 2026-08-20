using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem")]
    public class KubernetesAutomaticClusterHostedSystem : azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#node_subnet_id KubernetesAutomaticCluster#node_subnet_id}.</summary>
        [JsiiProperty(name: "nodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_automatic_cluster#system_node_subnet_id KubernetesAutomaticCluster#system_node_subnet_id}.</summary>
        [JsiiProperty(name: "systemNodeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SystemNodeSubnetId
        {
            get;
            set;
        }
    }
}
