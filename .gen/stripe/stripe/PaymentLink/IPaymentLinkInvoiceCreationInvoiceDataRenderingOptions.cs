using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions")]
    public interface IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions
    {
        /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#amount_tax_display PaymentLink#amount_tax_display}
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

        /// <summary>ID of the invoice rendering template to be used for the generated invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#template PaymentLink#template}
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

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#amount_tax_display PaymentLink#amount_tax_display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountTaxDisplay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the invoice rendering template to be used for the generated invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#template PaymentLink#template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Template
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
