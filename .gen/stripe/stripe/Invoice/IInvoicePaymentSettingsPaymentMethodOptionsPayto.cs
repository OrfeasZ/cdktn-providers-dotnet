using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPayto), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPayto")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsPayto
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#mandate_options Invoice#mandate_options}.</summary>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPayto), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPayto")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPayto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#mandate_options Invoice#mandate_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions?>();
            }
        }
    }
}
