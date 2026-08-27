using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVault")]
    public class ContainerAppEnvironmentCertificateCertificateKeyVault : azurerm.ContainerAppEnvironmentCertificate.IContainerAppEnvironmentCertificateCertificateKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#key_vault_secret_id ContainerAppEnvironmentCertificate#key_vault_secret_id}.</summary>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#identity ContainerAppEnvironmentCertificate#identity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identity
        {
            get;
            set;
        }
    }
}
