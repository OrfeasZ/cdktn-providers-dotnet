using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsBillie), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillie")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsBillie
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#company_details Invoice#company_details}.</summary>
        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>An identifier or reference that this payment corresponds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#reference Invoice#reference}
        /// </remarks>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsBillie), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillie")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillie
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#company_details Invoice#company_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails?>();
            }

            /// <summary>An identifier or reference that this payment corresponds to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#reference Invoice#reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
