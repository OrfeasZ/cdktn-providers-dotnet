using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings")]
    public interface ISubscriptionSchedulePauseSchedulesPauseSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#bill_for SubscriptionSchedule#bill_for}.</summary>
        [JsiiProperty(name: "billFor", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor? BillFor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how to handle debits and credits when pausing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#invoicing_behavior SubscriptionSchedule#invoicing_behavior}
        /// </remarks>
        [JsiiProperty(name: "invoicingBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvoicingBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of pause settings.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesPauseSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#bill_for SubscriptionSchedule#bill_for}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billFor", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor? BillFor
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor?>();
            }

            /// <summary>Determines how to handle debits and credits when pausing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#invoicing_behavior SubscriptionSchedule#invoicing_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoicingBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvoicingBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of pause settings.</summary>
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
