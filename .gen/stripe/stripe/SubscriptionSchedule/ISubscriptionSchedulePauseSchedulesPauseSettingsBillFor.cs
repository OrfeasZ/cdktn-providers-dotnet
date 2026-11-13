using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor")]
    public interface ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#outstanding_usage_through SubscriptionSchedule#outstanding_usage_through}.</summary>
        [JsiiProperty(name: "outstandingUsageThrough", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough? OutstandingUsageThrough
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#unused_time_from SubscriptionSchedule#unused_time_from}.</summary>
        [JsiiProperty(name: "unusedTimeFrom", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom? UnusedTimeFrom
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#outstanding_usage_through SubscriptionSchedule#outstanding_usage_through}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outstandingUsageThrough", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough? OutstandingUsageThrough
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#unused_time_from SubscriptionSchedule#unused_time_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unusedTimeFrom", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom? UnusedTimeFrom
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom?>();
            }
        }
    }
}
