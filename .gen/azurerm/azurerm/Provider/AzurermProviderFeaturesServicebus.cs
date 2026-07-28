using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeaturesServicebus")]
    public class AzurermProviderFeaturesServicebus : azurerm.Provider.IAzurermProviderFeaturesServicebus
    {
        private object? _autoDeleteSubscriptionDefaultRule;

        /// <summary>When enabled, the $Default rule is automatically deleted after creating a Service Bus subscription, preventing unfiltered message delivery.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs#auto_delete_subscription_default_rule AzurermProvider#auto_delete_subscription_default_rule}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoDeleteSubscriptionDefaultRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoDeleteSubscriptionDefaultRule
        {
            get => _autoDeleteSubscriptionDefaultRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoDeleteSubscriptionDefaultRule = value;
            }
        }
    }
}
