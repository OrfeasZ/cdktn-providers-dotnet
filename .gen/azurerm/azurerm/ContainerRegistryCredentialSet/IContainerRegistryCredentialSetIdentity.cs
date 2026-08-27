using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryCredentialSetIdentity), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity")]
    public interface IContainerRegistryCredentialSetIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_registry_credential_set#type ContainerRegistryCredentialSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryCredentialSetIdentity), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_registry_credential_set#type ContainerRegistryCredentialSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
