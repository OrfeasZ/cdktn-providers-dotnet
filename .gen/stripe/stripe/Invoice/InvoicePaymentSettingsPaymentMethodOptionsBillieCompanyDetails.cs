using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails")]
    public class InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#registered_address Invoice#registered_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
        {
            get;
            set;
        }

        /// <summary>Company or entity name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#registered_name Invoice#registered_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegisteredName
        {
            get;
            set;
        }

        /// <summary>The official registration number for the given registration type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#registration_number Invoice#registration_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrationNumber
        {
            get;
            set;
        }

        /// <summary>Type of registration the company or entity holds in their registered country.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#registration_type Invoice#registration_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrationType
        {
            get;
            set;
        }

        /// <summary>VAT ID number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#vat Invoice#vat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vat
        {
            get;
            set;
        }
    }
}
