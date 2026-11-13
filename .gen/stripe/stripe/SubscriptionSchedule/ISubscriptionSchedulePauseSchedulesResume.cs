using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesResume), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume")]
    public interface ISubscriptionSchedulePauseSchedulesResume
    {
        /// <summary>Time at which the subscription resumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume_at SubscriptionSchedule#resume_at}
        /// </remarks>
        [JsiiProperty(name: "resumeAt", typeJson: "{\"primitive\":\"number\"}")]
        double ResumeAt
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeSettings? Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesResume), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Time at which the subscription resumes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume_at SubscriptionSchedule#resume_at}
            /// </remarks>
            [JsiiProperty(name: "resumeAt", typeJson: "{\"primitive\":\"number\"}")]
            public double ResumeAt
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeSettings\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeSettings? Settings
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeSettings?>();
            }
        }
    }
}
