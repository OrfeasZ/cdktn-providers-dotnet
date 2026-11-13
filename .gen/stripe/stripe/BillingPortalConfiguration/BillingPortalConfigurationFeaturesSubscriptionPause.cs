using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPause")]
    public class BillingPortalConfigurationFeaturesSubscriptionPause : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPause
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#duration BillingPortalConfiguration#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration? Duration
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Whether the feature is enabled. Customers can only pause subscriptions in the [redesigned customer portal](/customer-management).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }
    }
}
