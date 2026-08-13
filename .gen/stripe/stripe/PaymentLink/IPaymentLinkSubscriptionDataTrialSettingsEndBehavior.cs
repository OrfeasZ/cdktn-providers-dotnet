using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkSubscriptionDataTrialSettingsEndBehavior), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettingsEndBehavior")]
    public interface IPaymentLinkSubscriptionDataTrialSettingsEndBehavior
    {
        /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#missing_payment_method PaymentLink#missing_payment_method}
        /// </remarks>
        [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        string MissingPaymentMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkSubscriptionDataTrialSettingsEndBehavior), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettingsEndBehavior")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettingsEndBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#missing_payment_method PaymentLink#missing_payment_method}
            /// </remarks>
            [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string MissingPaymentMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
