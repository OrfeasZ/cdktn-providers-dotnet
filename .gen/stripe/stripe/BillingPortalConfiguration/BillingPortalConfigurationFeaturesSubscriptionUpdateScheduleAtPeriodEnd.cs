using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd")]
    public class BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd
    {
        private object? _conditions;

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
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }
    }
}
