using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions")]
    public class BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions
    {
        /// <summary>The type of condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
