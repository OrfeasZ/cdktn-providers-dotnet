using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionTrialSettingsEndBehavior), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
    public interface ISubscriptionTrialSettingsEndBehavior
    {
        /// <summary>Indicates how the subscription's billing cycle anchor is reset when a trial ends.</summary>
        /// <remarks>
        /// If not set, the default is <c>now</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
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

        /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
        /// </remarks>
        [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MissingPaymentMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionTrialSettingsEndBehavior), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionTrialSettingsEndBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates how the subscription's billing cycle anchor is reset when a trial ends.</summary>
            /// <remarks>
            /// If not set, the default is <c>now</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingCycleAnchor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MissingPaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
