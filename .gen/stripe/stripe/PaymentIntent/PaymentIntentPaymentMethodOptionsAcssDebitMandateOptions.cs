using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitMandateOptions")]
    public class PaymentIntentPaymentMethodOptionsAcssDebitMandateOptions : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>A URL for custom mandate text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#custom_mandate_url PaymentIntent#custom_mandate_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMandateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomMandateUrl
        {
            get;
            set;
        }

        /// <summary>Description of the interval. Only required if the 'payment_schedule' parameter is 'interval' or 'combined'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval_description PaymentIntent#interval_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IntervalDescription
        {
            get;
            set;
        }

        /// <summary>Payment schedule for the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_schedule PaymentIntent#payment_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentSchedule
        {
            get;
            set;
        }

        /// <summary>Transaction type of the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transaction_type PaymentIntent#transaction_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransactionType
        {
            get;
            set;
        }
    }
}
