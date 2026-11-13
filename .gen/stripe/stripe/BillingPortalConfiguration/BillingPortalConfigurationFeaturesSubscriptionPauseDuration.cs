using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration")]
    public class BillingPortalConfigurationFeaturesSubscriptionPauseDuration : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration
    {
        /// <summary>Whether subscriptions can be paused indefinitely or for a preset duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _intervalOptions;

        /// <summary>The preset pause durations customers can choose from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#interval_options BillingPortalConfiguration#interval_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IntervalOptions
        {
            get => _intervalOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _intervalOptions = value;
            }
        }
    }
}
