using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionPause), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPause")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionPause
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#duration BillingPortalConfiguration#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the feature is enabled. Customers can only pause subscriptions in the [redesigned customer portal](/customer-management).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionPause), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPause")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#duration BillingPortalConfiguration#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration? Duration
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration?>();
            }

            /// <summary>Whether the feature is enabled. Customers can only pause subscriptions in the [redesigned customer portal](/customer-management).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
