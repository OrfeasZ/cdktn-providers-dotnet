using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterBootstrapProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterBootstrapProfile")]
    public interface IKubernetesClusterBootstrapProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#artifact_source KubernetesCluster#artifact_source}.</summary>
        [JsiiProperty(name: "artifactSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#container_registry_id KubernetesCluster#container_registry_id}.</summary>
        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerRegistryId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterBootstrapProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterBootstrapProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterBootstrapProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#artifact_source KubernetesCluster#artifact_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#container_registry_id KubernetesCluster#container_registry_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerRegistryId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
