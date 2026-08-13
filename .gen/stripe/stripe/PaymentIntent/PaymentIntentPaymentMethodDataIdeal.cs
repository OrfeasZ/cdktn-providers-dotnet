using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal")]
    public class PaymentIntentPaymentMethodDataIdeal : stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal
    {
        /// <summary>The customer's bank. Only use this parameter for existing customers. Don't use it for new customers.</summary>
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
