using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePauseSchedulesResumeSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeSettings")]
    public interface ISubscriptionSchedulePauseSchedulesResumeSettings
    {
        /// <summary>The billing cycle anchor that applies when the subscription is resumed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#billing_cycle_anchor SubscriptionSchedule#billing_cycle_anchor}
        /// </remarks>
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingCycleAnchor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether Stripe attempts payment on the resumption invoice and how that affects the subscription's status.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#payment_behavior SubscriptionSchedule#payment_behavior}
        /// </remarks>
        [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how to handle prorations resulting from the billing_cycle_anchor change on resume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#proration_behavior SubscriptionSchedule#proration_behavior}
        /// </remarks>
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePauseSchedulesResumeSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The billing cycle anchor that applies when the subscription is resumed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#billing_cycle_anchor SubscriptionSchedule#billing_cycle_anchor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingCycleAnchor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether Stripe attempts payment on the resumption invoice and how that affects the subscription's status.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#payment_behavior SubscriptionSchedule#payment_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Determines how to handle prorations resulting from the billing_cycle_anchor change on resume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#proration_behavior SubscriptionSchedule#proration_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
