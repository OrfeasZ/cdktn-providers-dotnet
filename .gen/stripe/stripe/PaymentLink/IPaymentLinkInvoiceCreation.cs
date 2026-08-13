using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkInvoiceCreation), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreation")]
    public interface IPaymentLinkInvoiceCreation
    {
        /// <summary>Enable creating an invoice on successful payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Configuration for the invoice. Default invoice values will be used if unspecified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_data PaymentLink#invoice_data}
        /// </remarks>
        [JsiiProperty(name: "invoiceData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData? InvoiceData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkInvoiceCreation), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreation")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkInvoiceCreation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable creating an invoice on successful payment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Configuration for the invoice. Default invoice values will be used if unspecified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_data PaymentLink#invoice_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData? InvoiceData
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData?>();
            }
        }
    }
}
