using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptions")]
    public class InvoicePaymentSettingsPaymentMethodOptions : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions
    {
        /// <summary>If paying by `acss_debit`, this sub-hash contains details about the Canadian pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#acss_debit Invoice#acss_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsAcssDebit? AcssDebit
        {
            get;
            set;
        }

        /// <summary>If paying by `bancontact`, this sub-hash contains details about the Bancontact payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#bancontact Invoice#bancontact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact? Bancontact
        {
            get;
            set;
        }

        /// <summary>If paying by `card`, this sub-hash contains details about the Card payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#card Invoice#card}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCard\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCard? Card
        {
            get;
            set;
        }

        /// <summary>If paying by `customer_balance`, this sub-hash contains details about the Bank transfer payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#customer_balance Invoice#customer_balance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance? CustomerBalance
        {
            get;
            set;
        }

        /// <summary>If paying by `payto`, this sub-hash contains details about the PayTo payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payto Invoice#payto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPayto\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPayto? Payto
        {
            get;
            set;
        }

        /// <summary>If paying by `pix`, this sub-hash contains details about the Pix payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pix Invoice#pix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix? Pix
        {
            get;
            set;
        }

        /// <summary>If paying by `upi`, this sub-hash contains details about the UPI payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#upi Invoice#upi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpi\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi? Upi
        {
            get;
            set;
        }

        /// <summary>If paying by `us_bank_account`, this sub-hash contains details about the ACH direct debit payment method options to pass to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#us_bank_account Invoice#us_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount? UsBankAccount
        {
            get;
            set;
        }
    }
}
