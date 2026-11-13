using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBlikMandateOptions")]
    public class PaymentIntentPaymentMethodOptionsBlikMandateOptions : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBlikMandateOptions
    {
        /// <summary>Date at which the mandate expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#expires_at PaymentIntent#expires_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAt
        {
            get;
            set;
        }
    }
}
