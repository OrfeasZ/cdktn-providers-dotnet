using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions
    {
        /// <summary>Amount to be charged for future payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount Subscription#amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>Determines if the amount includes the IOF tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount_includes_iof Subscription#amount_includes_iof}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountIncludesIof
        {
            get;
            set;
        }

        /// <summary>Date when the mandate expires and no further payments will be charged, in `YYYY-MM-DD`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end_date Subscription#end_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndDate
        {
            get;
            set;
        }

        /// <summary>Schedule at which the future payments will be charged.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_schedule Subscription#payment_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentSchedule
        {
            get;
            set;
        }
    }
}
