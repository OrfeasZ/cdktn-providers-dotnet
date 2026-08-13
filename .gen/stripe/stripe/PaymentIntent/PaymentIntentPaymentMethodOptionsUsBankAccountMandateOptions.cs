using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions")]
    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions
    {
        /// <summary>Mandate collection method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#collection_method PaymentIntent#collection_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionMethod
        {
            get;
            set;
        }
    }
}
