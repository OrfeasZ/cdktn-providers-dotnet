using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesDuration")]
    public class SubscriptionSchedulePhasesDuration : stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesDuration
    {
        /// <summary>Specifies phase duration. Either `day`, `week`, `month` or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval SubscriptionSchedule#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>The multiplier applied to the interval.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval_count SubscriptionSchedule#interval_count}
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
