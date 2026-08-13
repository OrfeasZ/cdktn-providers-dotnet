using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions
    {
        /// <summary>The maximum amount that can be collected in a single invoice.</summary>
        /// <remarks>
        /// If you don't specify a maximum, then there is no limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount Invoice#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#purpose Invoice#purpose}
        /// </remarks>
        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Purpose
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum amount that can be collected in a single invoice.</summary>
            /// <remarks>
            /// If you don't specify a maximum, then there is no limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount Invoice#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#purpose Invoice#purpose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Purpose
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
