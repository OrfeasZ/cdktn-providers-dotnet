using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkConsentCollectionPaymentMethodReuseAgreement), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement")]
    public interface IPaymentLinkConsentCollectionPaymentMethodReuseAgreement
    {
        /// <summary>Determines the position and visibility of the payment method reuse agreement in the UI.</summary>
        /// <remarks>
        /// When set to <c>auto</c>, Stripe's defaults will be used.
        ///
        /// When set to <c>hidden</c>, the payment method reuse agreement text will always be hidden in the UI.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#position PaymentLink#position}
        /// </remarks>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}")]
        string Position
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkConsentCollectionPaymentMethodReuseAgreement), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Determines the position and visibility of the payment method reuse agreement in the UI.</summary>
            /// <remarks>
            /// When set to <c>auto</c>, Stripe's defaults will be used.
            ///
            /// When set to <c>hidden</c>, the payment method reuse agreement text will always be hidden in the UI.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#position PaymentLink#position}
            /// </remarks>
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}")]
            public string Position
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
