using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesResourceGroup), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesResourceGroup")]
    public interface IAzurermProviderFeaturesResourceGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs#prevent_deletion_if_contains_resources AzurermProvider#prevent_deletion_if_contains_resources}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventDeletionIfContainsResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreventDeletionIfContainsResources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesResourceGroup), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesResourceGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesResourceGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs#prevent_deletion_if_contains_resources AzurermProvider#prevent_deletion_if_contains_resources}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preventDeletionIfContainsResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreventDeletionIfContainsResources
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
