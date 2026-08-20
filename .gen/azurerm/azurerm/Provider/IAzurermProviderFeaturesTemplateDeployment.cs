using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesTemplateDeployment), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesTemplateDeployment")]
    public interface IAzurermProviderFeaturesTemplateDeployment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs#delete_nested_items_during_deletion AzurermProvider#delete_nested_items_during_deletion}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteNestedItemsDuringDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DeleteNestedItemsDuringDeletion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesTemplateDeployment), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesTemplateDeployment")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs#delete_nested_items_during_deletion AzurermProvider#delete_nested_items_during_deletion}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "deleteNestedItemsDuringDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DeleteNestedItemsDuringDeletion
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
