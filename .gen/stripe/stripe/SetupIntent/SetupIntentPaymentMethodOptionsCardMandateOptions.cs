using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardMandateOptions")]
    public class SetupIntentPaymentMethodOptionsCardMandateOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardMandateOptions
    {
        /// <summary>Amount to be charged for future payments, specified in the presentment currency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>One of `fixed` or `maximum`.</summary>
        /// <remarks>
        /// If <c>fixed</c>, the <c>amount</c> param refers to the exact amount to be charged in future payments. If <c>maximum</c>, the amount charged can be up to the value passed for the <c>amount</c> param.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_type SetupIntent#amount_type}
        /// </remarks>
        [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}")]
        public string AmountType
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>Specifies payment frequency. One of `day`, `week`, `month`, `year`, or `sporadic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#interval SetupIntent#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Unique identifier for the mandate or subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#reference SetupIntent#reference}
        /// </remarks>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        public string Reference
        {
            get;
            set;
        }

        /// <summary>Start date of the mandate or subscription. Start date should not be lesser than yesterday.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#start_date SetupIntent#start_date}
        /// </remarks>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"number\"}")]
        public double StartDate
        {
            get;
            set;
        }

        /// <summary>A description of the mandate or subscription that is meant to be displayed to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#description SetupIntent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>End date of the mandate or subscription.</summary>
        /// <remarks>
        /// If not provided, the mandate will be active until canceled. If provided, end date should be after start date.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#end_date SetupIntent#end_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndDate
        {
            get;
            set;
        }

        /// <summary>The number of intervals between payments.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> indicates one payment every three months. Maximum of one year interval allowed (1 year, 12 months, or 52 weeks). This parameter is optional when <c>interval=sporadic</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#interval_count SetupIntent#interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalCount
        {
            get;
            set;
        }

        /// <summary>Specifies the type of mandates supported. Possible values are `india`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#supported_types SetupIntent#supported_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "supportedTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SupportedTypes
        {
            get;
            set;
        }
    }
}
