using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna")]
    public class PaymentIntentPaymentMethodDataKlarna : stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna
    {
        /// <summary>Customer's date of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#dob PaymentIntent#dob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarnaDob? Dob
        {
            get;
            set;
        }
    }
}
