using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentMandateData")]
    public class PaymentIntentMandateData : stripe.PaymentIntent.IPaymentIntentMandateData
    {
        /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer_acceptance PaymentIntent#customer_acceptance}
        /// </remarks>
        [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance\"}")]
        public stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance CustomerAcceptance
        {
            get;
            set;
        }
    }
}
