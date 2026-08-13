using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionBillingMode")]
    public class SubscriptionBillingMode : stripe.Subscription.ISubscriptionBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Configure behavior for flexible billing mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#flexible Subscription#flexible}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingModeFlexible\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionBillingModeFlexible? Flexible
        {
            get;
            set;
        }
    }
}
