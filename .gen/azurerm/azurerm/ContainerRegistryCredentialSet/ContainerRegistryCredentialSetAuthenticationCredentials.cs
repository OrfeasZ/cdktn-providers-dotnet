using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials")]
    public class ContainerRegistryCredentialSetAuthenticationCredentials : azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_registry_credential_set#password_secret_id ContainerRegistryCredentialSet#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_registry_credential_set#username_secret_id ContainerRegistryCredentialSet#username_secret_id}.</summary>
        [JsiiProperty(name: "usernameSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string UsernameSecretId
        {
            get;
            set;
        }
    }
}
