using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesDatabricksWorkspace), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesDatabricksWorkspace")]
    public interface IAzurermProviderFeaturesDatabricksWorkspace
    {
        /// <summary>When enabled, the managed resource group that contains the Unity Catalog data will be forcibly deleted when the workspace is destroyed, regardless of contents.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#force_delete AzurermProvider#force_delete}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDelete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesDatabricksWorkspace), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesDatabricksWorkspace")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When enabled, the managed resource group that contains the Unity Catalog data will be forcibly deleted when the workspace is destroyed, regardless of contents.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#force_delete AzurermProvider#force_delete}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDelete
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
