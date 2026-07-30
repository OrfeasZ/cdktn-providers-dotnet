using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterBootstrapProfile")]
    public class KubernetesClusterBootstrapProfile : azurerm.KubernetesCluster.IKubernetesClusterBootstrapProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster#artifact_source KubernetesCluster#artifact_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_cluster#container_registry_id KubernetesCluster#container_registry_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerRegistryId
        {
            get;
            set;
        }
    }
}
