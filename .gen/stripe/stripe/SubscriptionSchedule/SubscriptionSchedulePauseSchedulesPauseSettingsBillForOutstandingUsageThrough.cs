using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough")]
    public class SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough
    {
        /// <summary>The type of outstanding usage billing behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
