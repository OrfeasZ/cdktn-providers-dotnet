using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterDeploymentSafeguard
{
    [JsiiByValue(fqn: "azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardTimeouts")]
    public class KubernetesClusterDeploymentSafeguardTimeouts : azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster_deployment_safeguard#create KubernetesClusterDeploymentSafeguard#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster_deployment_safeguard#delete KubernetesClusterDeploymentSafeguard#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster_deployment_safeguard#read KubernetesClusterDeploymentSafeguard#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster_deployment_safeguard#update KubernetesClusterDeploymentSafeguard#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
