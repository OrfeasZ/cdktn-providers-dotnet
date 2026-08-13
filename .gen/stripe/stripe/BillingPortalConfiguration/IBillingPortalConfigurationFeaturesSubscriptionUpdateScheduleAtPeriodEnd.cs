using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd
    {
        /// <summary>List of conditions.</summary>
        /// <remarks>
        /// When any condition is true, an update will be scheduled at the end of the current period.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#conditions BillingPortalConfiguration#conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Conditions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of conditions.</summary>
            /// <remarks>
            /// When any condition is true, an update will be scheduled at the end of the current period.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#conditions BillingPortalConfiguration#conditions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Conditions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
