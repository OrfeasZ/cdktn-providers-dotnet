using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance")]
    public class PaymentIntentMandateDataCustomerAcceptance : stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance
    {
        /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The time at which the customer accepted the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#accepted_at PaymentIntent#accepted_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AcceptedAt
        {
            get;
            set;
        }

        /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#online PaymentIntent#online}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptanceOnline? Online
        {
            get;
            set;
        }
    }
}
