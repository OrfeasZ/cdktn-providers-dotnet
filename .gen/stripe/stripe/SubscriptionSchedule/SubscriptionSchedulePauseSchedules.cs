using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedules")]
    public class SubscriptionSchedulePauseSchedules : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedules
    {
        /// <summary>A unique identifier for this pause schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#key SubscriptionSchedule#key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause SubscriptionSchedule#pause}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pause", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause? Pause
        {
            get;
            set;
        }

        /// <summary>Details about when and how the subscription resumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume SubscriptionSchedule#resume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resume", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume? Resume
        {
            get;
            set;
        }
    }
}
