using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresentRouting")]
    public class PaymentIntentPaymentMethodOptionsCardPresentRouting : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardPresentRouting
    {
        /// <summary>Requested routing priority.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested_priority PaymentIntent#requested_priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestedPriority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestedPriority
        {
            get;
            set;
        }
    }
}
