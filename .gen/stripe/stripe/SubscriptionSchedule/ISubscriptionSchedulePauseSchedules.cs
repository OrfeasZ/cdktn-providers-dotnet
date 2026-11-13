using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedules), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedules")]
    public interface ISubscriptionSchedulePauseSchedules
    {
        /// <summary>A unique identifier for this pause schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#key SubscriptionSchedule#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause SubscriptionSchedule#pause}.</summary>
        [JsiiProperty(name: "pause", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause? Pause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Details about when and how the subscription resumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume SubscriptionSchedule#resume}
        /// </remarks>
        [JsiiProperty(name: "resume", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume? Resume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedules), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedules")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A unique identifier for this pause schedule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#key SubscriptionSchedule#key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause SubscriptionSchedule#pause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pause", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause? Pause
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause?>();
            }

            /// <summary>Details about when and how the subscription resumes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#resume SubscriptionSchedule#resume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resume", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResume\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume? Resume
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResume?>();
            }
        }
    }
}
