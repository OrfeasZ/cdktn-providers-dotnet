using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough")]
    public interface ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough
    {
        /// <summary>The type of outstanding usage billing behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of outstanding usage billing behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
