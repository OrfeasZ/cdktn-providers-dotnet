using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor")]
    public class SubscriptionSchedulePauseSchedulesPauseSettingsBillFor : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#outstanding_usage_through SubscriptionSchedule#outstanding_usage_through}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outstandingUsageThrough", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough? OutstandingUsageThrough
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#unused_time_from SubscriptionSchedule#unused_time_from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unusedTimeFrom", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom? UnusedTimeFrom
        {
            get;
            set;
        }
    }
}
