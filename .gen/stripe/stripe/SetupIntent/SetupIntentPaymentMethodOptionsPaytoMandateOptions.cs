using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsPaytoMandateOptions")]
    public class SetupIntentPaymentMethodOptionsPaytoMandateOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaytoMandateOptions
    {
        /// <summary>Amount that will be collected. It is required when `amount_type` is `fixed`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>The type of amount that will be collected.</summary>
        /// <remarks>
        /// The amount charged must be exact or up to the value of <c>amount</c> param for <c>fixed</c> or <c>maximum</c> type respectively. Defaults to <c>maximum</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_type SetupIntent#amount_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountType
        {
            get;
            set;
        }

        /// <summary>Date, in YYYY-MM-DD format, after which payments will not be collected. Defaults to no end date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#end_date SetupIntent#end_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndDate
        {
            get;
            set;
        }

        /// <summary>The periodicity at which payments will be collected. Defaults to `adhoc`.</summary>
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

        /// <summary>The number of payments that will be made during a payment period.</summary>
        /// <remarks>
        /// Defaults to 1 except for when <c>payment_schedule</c> is <c>adhoc</c>. In that case, it defaults to no limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payments_per_period SetupIntent#payments_per_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PaymentsPerPeriod
        {
            get;
            set;
        }

        /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#purpose SetupIntent#purpose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Purpose
        {
            get;
            set;
        }

        /// <summary>Date, in YYYY-MM-DD format, from which payments will be collected. Defaults to confirmation time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#start_date SetupIntent#start_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartDate
        {
            get;
            set;
        }
    }
}
