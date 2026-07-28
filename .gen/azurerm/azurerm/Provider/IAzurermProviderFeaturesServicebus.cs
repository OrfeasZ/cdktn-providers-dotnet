using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesServicebus), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesServicebus")]
    public interface IAzurermProviderFeaturesServicebus
    {
        /// <summary>When enabled, the $Default rule is automatically deleted after creating a Service Bus subscription, preventing unfiltered message delivery.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs#auto_delete_subscription_default_rule AzurermProvider#auto_delete_subscription_default_rule}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoDeleteSubscriptionDefaultRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoDeleteSubscriptionDefaultRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesServicebus), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesServicebus")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesServicebus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When enabled, the $Default rule is automatically deleted after creating a Service Bus subscription, preventing unfiltered message delivery.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs#auto_delete_subscription_default_rule AzurermProvider#auto_delete_subscription_default_rule}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoDeleteSubscriptionDefaultRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoDeleteSubscriptionDefaultRule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
