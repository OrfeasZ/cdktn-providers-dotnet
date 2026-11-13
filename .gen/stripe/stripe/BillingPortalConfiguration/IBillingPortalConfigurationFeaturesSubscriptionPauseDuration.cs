using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionPauseDuration), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionPauseDuration
    {
        /// <summary>Whether subscriptions can be paused indefinitely or for a preset duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The preset pause durations customers can choose from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#interval_options BillingPortalConfiguration#interval_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "intervalOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IntervalOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionPauseDuration), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether subscriptions can be paused indefinitely or for a preset duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The preset pause durations customers can choose from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#interval_options BillingPortalConfiguration#interval_options}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IntervalOptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
