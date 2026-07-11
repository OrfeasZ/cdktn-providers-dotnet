using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryCredentialSetAuthenticationCredentials), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials")]
    public interface IContainerRegistryCredentialSetAuthenticationCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set#password_secret_id ContainerRegistryCredentialSet#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set#username_secret_id ContainerRegistryCredentialSet#username_secret_id}.</summary>
        [JsiiProperty(name: "usernameSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string UsernameSecretId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryCredentialSetAuthenticationCredentials), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set#password_secret_id ContainerRegistryCredentialSet#password_secret_id}.</summary>
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set#username_secret_id ContainerRegistryCredentialSet#username_secret_id}.</summary>
            [JsiiProperty(name: "usernameSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string UsernameSecretId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
