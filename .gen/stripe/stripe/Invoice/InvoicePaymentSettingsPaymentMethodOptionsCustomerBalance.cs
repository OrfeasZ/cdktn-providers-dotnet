using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance")]
    public class InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#bank_transfer Invoice#bank_transfer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer? BankTransfer
        {
            get;
            set;
        }

        /// <summary>The funding method type to be used when there are not enough funds in the customer balance.</summary>
        /// <remarks>
        /// Permitted values include: <c>bank_transfer</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#funding_type Invoice#funding_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FundingType
        {
            get;
            set;
        }
    }
}
