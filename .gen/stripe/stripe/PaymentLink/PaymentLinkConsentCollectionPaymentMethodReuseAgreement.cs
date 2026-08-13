using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement")]
    public class PaymentLinkConsentCollectionPaymentMethodReuseAgreement : stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement
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
        public string Position
        {
            get;
            set;
        }
    }
}
