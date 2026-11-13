using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume")]
    public class SubscriptionSchedulePauseSchedulesResume : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume
    {
        /// <summary>Time at which the subscription resumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume_at SubscriptionSchedule#resume_at}
        /// </remarks>
        [JsiiProperty(name: "resumeAt", typeJson: "{\"primitive\":\"number\"}")]
        public double ResumeAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeSettings\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeSettings? Settings
        {
            get;
            set;
        }
    }
}
