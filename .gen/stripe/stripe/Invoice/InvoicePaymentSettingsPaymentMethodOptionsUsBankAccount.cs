using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount")]
    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#financial_connections Invoice#financial_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
        {
            get;
            set;
        }

        /// <summary>Bank account verification method. The default value is `automatic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#verification_method Invoice#verification_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerificationMethod
        {
            get;
            set;
        }
    }
}
