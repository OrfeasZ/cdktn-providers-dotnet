using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptance")]
    public class PaymentLinkCustomTextTermsOfServiceAcceptance : stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance
    {
        /// <summary>Text can be up to 1200 characters in length.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#message PaymentLink#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public string Message
        {
            get;
            set;
        }
    }
}
