using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
    {
        /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#account_subcategories Invoice#account_subcategories}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountSubcategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AccountSubcategories
        {
            get;
            set;
        }
    }
}
