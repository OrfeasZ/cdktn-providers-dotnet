using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsBancontact), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsBancontact
    {
        /// <summary>Preferred language of the Bancontact authorization page that the customer is redirected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#preferred_language Invoice#preferred_language}
        /// </remarks>
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLanguage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsBancontact), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Preferred language of the Bancontact authorization page that the customer is redirected to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#preferred_language Invoice#preferred_language}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLanguage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
