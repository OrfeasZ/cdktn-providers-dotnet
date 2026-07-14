using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderEnhancedValidation), fullyQualifiedName: "azurerm.provider.AzurermProviderEnhancedValidation")]
    public interface IAzurermProviderEnhancedValidation
    {
        /// <summary>Should the AzureRM Provider validate location arguments against the list of supported Azure Locations?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#locations AzurermProvider#locations}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "locations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AzureRM Provider validate Resource Provider arguments against the list of supported Resource Providers?</summary>
        /// <remarks>
        /// When enabled, invalid resource providers are caught at plan time; when disabled, they are caught at apply time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#resource_providers AzurermProvider#resource_providers}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "resourceProviders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceProviders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderEnhancedValidation), fullyQualifiedName: "azurerm.provider.AzurermProviderEnhancedValidation")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderEnhancedValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Should the AzureRM Provider validate location arguments against the list of supported Azure Locations?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#locations AzurermProvider#locations}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Locations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the AzureRM Provider validate Resource Provider arguments against the list of supported Resource Providers?</summary>
            /// <remarks>
            /// When enabled, invalid resource providers are caught at plan time; when disabled, they are caught at apply time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#resource_providers AzurermProvider#resource_providers}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceProviders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ResourceProviders
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
