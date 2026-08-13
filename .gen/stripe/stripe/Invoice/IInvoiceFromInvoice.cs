using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceFromInvoice), fullyQualifiedName: "stripe.invoice.InvoiceFromInvoice")]
    public interface IInvoiceFromInvoice
    {
        /// <summary>The relation between this invoice and the cloned invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#action Invoice#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>The invoice that was cloned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#invoice Invoice#invoice}
        /// </remarks>
        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        string Invoice
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceFromInvoice), fullyQualifiedName: "stripe.invoice.InvoiceFromInvoice")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceFromInvoice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The relation between this invoice and the cloned invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#action Invoice#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The invoice that was cloned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#invoice Invoice#invoice}
            /// </remarks>
            [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
            public string Invoice
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
