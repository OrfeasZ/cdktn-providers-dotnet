using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceRenderingPdf), fullyQualifiedName: "stripe.invoice.InvoiceRenderingPdf")]
    public interface IInvoiceRenderingPdf
    {
        /// <summary>Page size of invoice pdf.</summary>
        /// <remarks>
        /// Options include a4, letter, and auto. If set to auto, page size will be switched to a4 or letter based on customer locale.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#page_size Invoice#page_size}
        /// </remarks>
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PageSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceRenderingPdf), fullyQualifiedName: "stripe.invoice.InvoiceRenderingPdf")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceRenderingPdf
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Page size of invoice pdf.</summary>
            /// <remarks>
            /// Options include a4, letter, and auto. If set to auto, page size will be switched to a4 or letter based on customer locale.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#page_size Invoice#page_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageSize
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
