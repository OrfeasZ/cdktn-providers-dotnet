using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceAutomaticTax), fullyQualifiedName: "stripe.invoice.InvoiceAutomaticTax")]
    public interface IInvoiceAutomaticTax
    {
        /// <summary>Whether Stripe automatically computes tax on this invoice.</summary>
        /// <remarks>
        /// Note that incompatible invoice items (invoice items with manually specified <a href="https://docs.stripe.com/api/tax_rates">tax rates</a>, negative amounts, or <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#enabled Invoice#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The account that's liable for tax.</summary>
        /// <remarks>
        /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#liability Invoice#liability}
        /// </remarks>
        [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceAutomaticTaxLiability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceAutomaticTaxLiability? Liability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceAutomaticTax), fullyQualifiedName: "stripe.invoice.InvoiceAutomaticTax")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceAutomaticTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether Stripe automatically computes tax on this invoice.</summary>
            /// <remarks>
            /// Note that incompatible invoice items (invoice items with manually specified <a href="https://docs.stripe.com/api/tax_rates">tax rates</a>, negative amounts, or <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#enabled Invoice#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The account that's liable for tax.</summary>
            /// <remarks>
            /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#liability Invoice#liability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceAutomaticTaxLiability\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceAutomaticTaxLiability? Liability
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceAutomaticTaxLiability?>();
            }
        }
    }
}
