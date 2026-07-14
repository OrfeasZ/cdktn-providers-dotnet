using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity")]
    public class ContainerRegistryCredentialSetIdentity : azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_registry_credential_set#type ContainerRegistryCredentialSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
