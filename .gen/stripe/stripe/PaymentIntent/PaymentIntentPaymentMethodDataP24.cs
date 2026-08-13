using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodDataP24")]
    public class PaymentIntentPaymentMethodDataP24 : stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24
    {
        /// <summary>The customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank PaymentIntent#bank}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bank
        {
            get;
            set;
        }
    }
}
