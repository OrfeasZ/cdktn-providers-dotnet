using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionScheduleBillingMode")]
    public class SubscriptionScheduleBillingMode : stripe.SubscriptionSchedule.ISubscriptionScheduleBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Configure behavior for flexible billing mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#flexible SubscriptionSchedule#flexible}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingModeFlexible\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionScheduleBillingModeFlexible? Flexible
        {
            get;
            set;
        }
    }
}
