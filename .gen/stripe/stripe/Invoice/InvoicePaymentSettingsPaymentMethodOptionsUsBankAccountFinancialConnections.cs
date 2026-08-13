using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections")]
    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#filters Invoice#filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
        {
            get;
            set;
        }

        /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#permissions Invoice#permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        /// <summary>Data features requested to be retrieved upon account creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#prefetch Invoice#prefetch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefetch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Prefetch
        {
            get;
            set;
        }
    }
}
