using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause")]
    public class SubscriptionSchedulePauseSchedulesPause : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause
    {
        /// <summary>Time at which the subscription pauses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause_at SubscriptionSchedule#pause_at}
        /// </remarks>
        [JsiiProperty(name: "pauseAt", typeJson: "{\"primitive\":\"number\"}")]
        public double PauseAt
        {
            get;
            set;
        }

        /// <summary>Settings controlling billing behavior during the pause.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings? Settings
        {
            get;
            set;
        }
    }
}
