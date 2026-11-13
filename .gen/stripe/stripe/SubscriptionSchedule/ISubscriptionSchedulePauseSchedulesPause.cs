using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPause), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause")]
    public interface ISubscriptionSchedulePauseSchedulesPause
    {
        /// <summary>Time at which the subscription pauses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause_at SubscriptionSchedule#pause_at}
        /// </remarks>
        [JsiiProperty(name: "pauseAt", typeJson: "{\"primitive\":\"number\"}")]
        double PauseAt
        {
            get;
        }

        /// <summary>Settings controlling billing behavior during the pause.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings? Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPause), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPause")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Time at which the subscription pauses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#pause_at SubscriptionSchedule#pause_at}
            /// </remarks>
            [JsiiProperty(name: "pauseAt", typeJson: "{\"primitive\":\"number\"}")]
            public double PauseAt
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Settings controlling billing behavior during the pause.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#settings SubscriptionSchedule#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings? Settings
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings?>();
            }
        }
    }
}
