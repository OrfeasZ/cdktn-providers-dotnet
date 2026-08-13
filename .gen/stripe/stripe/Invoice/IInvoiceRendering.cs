using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceRendering), fullyQualifiedName: "stripe.invoice.InvoiceRendering")]
    public interface IInvoiceRendering
    {
        /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount_tax_display Invoice#amount_tax_display}
        /// </remarks>
        [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmountTaxDisplay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Invoice pdf rendering options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pdf Invoice#pdf}
        /// </remarks>
        [JsiiProperty(name: "pdf", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRenderingPdf\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceRenderingPdf? Pdf
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the rendering template that the invoice is formatted by.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template Invoice#template}
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Template
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version of the rendering template that the invoice is using.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template_version Invoice#template_version}
        /// </remarks>
        [JsiiProperty(name: "templateVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TemplateVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceRendering), fullyQualifiedName: "stripe.invoice.InvoiceRendering")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceRendering
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount_tax_display Invoice#amount_tax_display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountTaxDisplay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Invoice pdf rendering options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pdf Invoice#pdf}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pdf", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRenderingPdf\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceRenderingPdf? Pdf
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceRenderingPdf?>();
            }

            /// <summary>ID of the rendering template that the invoice is formatted by.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template Invoice#template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Template
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Version of the rendering template that the invoice is using.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template_version Invoice#template_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TemplateVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
