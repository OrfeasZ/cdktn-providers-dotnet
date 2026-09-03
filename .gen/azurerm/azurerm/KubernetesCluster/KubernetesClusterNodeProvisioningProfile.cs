using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterNodeProvisioningProfile")]
    public class KubernetesClusterNodeProvisioningProfile : azurerm.KubernetesCluster.IKubernetesClusterNodeProvisioningProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#default_node_pools KubernetesCluster#default_node_pools}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultNodePools", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultNodePools
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#mode KubernetesCluster#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
