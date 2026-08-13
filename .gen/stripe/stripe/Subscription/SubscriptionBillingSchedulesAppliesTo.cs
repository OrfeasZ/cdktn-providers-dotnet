using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionBillingSchedulesAppliesTo")]
    public class SubscriptionBillingSchedulesAppliesTo : stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo
    {
        /// <summary>Controls which subscription items the billing schedule applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The billing schedule will apply to the subscription item with the given price ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price Subscription#price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Price
        {
            get;
            set;
        }
    }
}
