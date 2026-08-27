using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentCertificate
{
    [JsiiInterface(nativeType: typeof(IContainerAppEnvironmentCertificateCertificateKeyVault), fullyQualifiedName: "azurerm.containerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVault")]
    public interface IContainerAppEnvironmentCertificateCertificateKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#key_vault_secret_id ContainerAppEnvironmentCertificate#key_vault_secret_id}.</summary>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#identity ContainerAppEnvironmentCertificate#identity}.</summary>
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppEnvironmentCertificateCertificateKeyVault), fullyQualifiedName: "azurerm.containerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVault")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppEnvironmentCertificate.IContainerAppEnvironmentCertificateCertificateKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#key_vault_secret_id ContainerAppEnvironmentCertificate#key_vault_secret_id}.</summary>
            [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app_environment_certificate#identity ContainerAppEnvironmentCertificate#identity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
