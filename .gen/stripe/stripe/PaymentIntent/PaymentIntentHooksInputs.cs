using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentHooksInputs")]
    public class PaymentIntentHooksInputs : stripe.PaymentIntent.IPaymentIntentHooksInputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax PaymentIntent#tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputsTax\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentHooksInputsTax? Tax
        {
            get;
            set;
        }
    }
}
