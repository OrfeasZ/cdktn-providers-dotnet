using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionTrialSettingsEndBehavior), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
    public interface ISubscriptionTrialSettingsEndBehavior
    {
        /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
        /// </remarks>
        [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        string MissingPaymentMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionTrialSettingsEndBehavior), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionTrialSettingsEndBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
            /// </remarks>
            [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string MissingPaymentMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
