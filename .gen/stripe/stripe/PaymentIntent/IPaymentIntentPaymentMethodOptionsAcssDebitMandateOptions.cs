using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsAcssDebitMandateOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitMandateOptions")]
    public interface IPaymentIntentPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>A URL for custom mandate text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#custom_mandate_url PaymentIntent#custom_mandate_url}
        /// </remarks>
        [JsiiProperty(name: "customMandateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomMandateUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the interval. Only required if the 'payment_schedule' parameter is 'interval' or 'combined'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval_description PaymentIntent#interval_description}
        /// </remarks>
        [JsiiProperty(name: "intervalDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntervalDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Payment schedule for the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_schedule PaymentIntent#payment_schedule}
        /// </remarks>
        [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Transaction type of the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transaction_type PaymentIntent#transaction_type}
        /// </remarks>
        [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransactionType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsAcssDebitMandateOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAcssDebitMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A URL for custom mandate text.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#custom_mandate_url PaymentIntent#custom_mandate_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customMandateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomMandateUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the interval. Only required if the 'payment_schedule' parameter is 'interval' or 'combined'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval_description PaymentIntent#interval_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntervalDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Payment schedule for the mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_schedule PaymentIntent#payment_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentSchedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Transaction type of the mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transaction_type PaymentIntent#transaction_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransactionType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
