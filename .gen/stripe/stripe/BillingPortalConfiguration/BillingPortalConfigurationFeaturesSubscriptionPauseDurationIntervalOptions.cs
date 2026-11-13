using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions")]
    public class BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions
    {
        /// <summary>Specifies the pause duration unit. Either `day`, `week`, `month`, or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#interval BillingPortalConfiguration#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>The number of intervals in the pause duration. The maximum duration is three years.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/billing_portal_configuration#interval_count BillingPortalConfiguration#interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalCount
        {
            get;
            set;
        }
    }
}
