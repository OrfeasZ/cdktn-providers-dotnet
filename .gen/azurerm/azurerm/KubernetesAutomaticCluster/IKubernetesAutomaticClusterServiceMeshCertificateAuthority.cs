using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesAutomaticClusterServiceMeshCertificateAuthority), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority")]
    public interface IKubernetesAutomaticClusterServiceMeshCertificateAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#certificate_chain_object_name KubernetesAutomaticCluster#certificate_chain_object_name}.</summary>
        [JsiiProperty(name: "certificateChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateChainObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#certificate_object_name KubernetesAutomaticCluster#certificate_object_name}.</summary>
        [JsiiProperty(name: "certificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#key_object_name KubernetesAutomaticCluster#key_object_name}.</summary>
        [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string KeyObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#key_vault_id KubernetesAutomaticCluster#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#root_certificate_object_name KubernetesAutomaticCluster#root_certificate_object_name}.</summary>
        [JsiiProperty(name: "rootCertificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string RootCertificateObjectName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesAutomaticClusterServiceMeshCertificateAuthority), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#certificate_chain_object_name KubernetesAutomaticCluster#certificate_chain_object_name}.</summary>
            [JsiiProperty(name: "certificateChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateChainObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#certificate_object_name KubernetesAutomaticCluster#certificate_object_name}.</summary>
            [JsiiProperty(name: "certificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#key_object_name KubernetesAutomaticCluster#key_object_name}.</summary>
            [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#key_vault_id KubernetesAutomaticCluster#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#root_certificate_object_name KubernetesAutomaticCluster#root_certificate_object_name}.</summary>
            [JsiiProperty(name: "rootCertificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string RootCertificateObjectName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
