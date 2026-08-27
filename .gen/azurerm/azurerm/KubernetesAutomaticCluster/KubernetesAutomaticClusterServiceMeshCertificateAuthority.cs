using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority")]
    public class KubernetesAutomaticClusterServiceMeshCertificateAuthority : azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#certificate_chain_object_name KubernetesAutomaticCluster#certificate_chain_object_name}.</summary>
        [JsiiProperty(name: "certificateChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateChainObjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#certificate_object_name KubernetesAutomaticCluster#certificate_object_name}.</summary>
        [JsiiProperty(name: "certificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateObjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#key_object_name KubernetesAutomaticCluster#key_object_name}.</summary>
        [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyObjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#key_vault_id KubernetesAutomaticCluster#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#root_certificate_object_name KubernetesAutomaticCluster#root_certificate_object_name}.</summary>
        [JsiiProperty(name: "rootCertificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public string RootCertificateObjectName
        {
            get;
            set;
        }
    }
}
