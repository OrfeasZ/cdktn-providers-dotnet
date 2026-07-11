using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurestackProviderFeaturesResourceGroup), fullyQualifiedName: "azurestack.provider.AzurestackProviderFeaturesResourceGroup")]
    public interface IAzurestackProviderFeaturesResourceGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#prevent_deletion_if_contains_resources AzurestackProvider#prevent_deletion_if_contains_resources}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IAzurestackProviderFeaturesResourceGroup), fullyQualifiedName: "azurestack.provider.AzurestackProviderFeaturesResourceGroup")]
        internal sealed class _Proxy : DeputyBase, azurestack.Provider.IAzurestackProviderFeaturesResourceGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#prevent_deletion_if_contains_resources AzurestackProvider#prevent_deletion_if_contains_resources}.</summary>
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
