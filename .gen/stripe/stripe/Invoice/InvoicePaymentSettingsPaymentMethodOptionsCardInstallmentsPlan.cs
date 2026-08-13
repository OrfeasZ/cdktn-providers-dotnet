using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlan")]
    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlan : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlan
    {
        /// <summary>Type of installment plan, one of `fixed_count`, `bonus`, or `revolving`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#type Invoice#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>For `fixed_count` installment plans, this is required.</summary>
        /// <remarks>
        /// It represents the number of installment payments your customer will make to their credit card.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#count Invoice#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <summary>For `fixed_count` installment plans, this is required.</summary>
        /// <remarks>
        /// It represents the interval between installment payments your customer will make to their credit card.
        /// One of <c>month</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#interval Invoice#interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Interval
        {
            get;
            set;
        }
    }
}
