using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkPaymentMethodOptions")]
    public class PaymentLinkPaymentMethodOptions : stripe.PaymentLink.IPaymentLinkPaymentMethodOptions
    {
        /// <summary>Configuration for `card` payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#card PaymentLink#card}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsCard\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCard? Card
        {
            get;
            set;
        }
    }
}
