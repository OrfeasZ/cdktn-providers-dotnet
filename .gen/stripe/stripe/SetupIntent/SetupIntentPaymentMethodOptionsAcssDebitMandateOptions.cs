using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebitMandateOptions")]
    public class SetupIntentPaymentMethodOptionsAcssDebitMandateOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>A URL for custom mandate text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#custom_mandate_url SetupIntent#custom_mandate_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMandateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomMandateUrl
        {
            get;
            set;
        }

        /// <summary>List of Stripe products where this mandate can be selected automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#default_for SetupIntent#default_for}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultFor", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultFor
        {
            get;
            set;
        }

        /// <summary>Description of the interval. Only required if the 'payment_schedule' parameter is 'interval' or 'combined'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#interval_description SetupIntent#interval_description}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_schedule SetupIntent#payment_schedule}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#transaction_type SetupIntent#transaction_type}
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
