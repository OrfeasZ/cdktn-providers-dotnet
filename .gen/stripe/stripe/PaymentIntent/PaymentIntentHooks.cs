using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentHooks")]
    public class PaymentIntentHooks : stripe.PaymentIntent.IPaymentIntentHooks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#inputs PaymentIntent#inputs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputs\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentHooksInputs? Inputs
        {
            get;
            set;
        }
    }
}
