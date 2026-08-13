using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountNetworks")]
    public class PaymentIntentPaymentMethodOptionsUsBankAccountNetworks : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountNetworks
    {
        /// <summary>Triggers validations to run across the selected networks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested PaymentIntent#requested}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requested", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Requested
        {
            get;
            set;
        }
    }
}
