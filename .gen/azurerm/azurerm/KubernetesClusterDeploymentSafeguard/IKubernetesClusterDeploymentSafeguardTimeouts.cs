using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterDeploymentSafeguard
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDeploymentSafeguardTimeouts), fullyQualifiedName: "azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardTimeouts")]
    public interface IKubernetesClusterDeploymentSafeguardTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#create KubernetesClusterDeploymentSafeguard#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#delete KubernetesClusterDeploymentSafeguard#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#read KubernetesClusterDeploymentSafeguard#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#update KubernetesClusterDeploymentSafeguard#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDeploymentSafeguardTimeouts), fullyQualifiedName: "azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#create KubernetesClusterDeploymentSafeguard#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#delete KubernetesClusterDeploymentSafeguard#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#read KubernetesClusterDeploymentSafeguard#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster_deployment_safeguard#update KubernetesClusterDeploymentSafeguard#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
