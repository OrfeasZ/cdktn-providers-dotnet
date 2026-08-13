using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionBillingSchedulesBillUntil")]
    public class SubscriptionBillingSchedulesBillUntil : stripe.Subscription.ISubscriptionBillingSchedulesBillUntil
    {
        /// <summary>Describes how the billing schedule will determine the end date. Either `duration` or `timestamp`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Specifies the billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#duration Subscription#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDuration\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration? Duration
        {
            get;
            set;
        }

        /// <summary>If specified, the billing schedule will apply until the specified timestamp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#timestamp Subscription#timestamp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timestamp
        {
            get;
            set;
        }
    }
}
