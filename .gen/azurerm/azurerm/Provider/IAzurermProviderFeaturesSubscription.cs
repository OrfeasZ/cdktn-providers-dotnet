using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesSubscription), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesSubscription")]
    public interface IAzurermProviderFeaturesSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs#prevent_cancellation_on_destroy AzurermProvider#prevent_cancellation_on_destroy}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventCancellationOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreventCancellationOnDestroy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesSubscription), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesSubscription")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs#prevent_cancellation_on_destroy AzurermProvider#prevent_cancellation_on_destroy}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preventCancellationOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreventCancellationOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
