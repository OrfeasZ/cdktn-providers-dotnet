using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPix), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsPix
    {
        /// <summary>Determines if the amount includes the IOF tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#amount_includes_iof Invoice#amount_includes_iof}
        /// </remarks>
        [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmountIncludesIof
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds after PaymentIntent confirmation when the Pix expires (between 60 and 1209600, inclusive).</summary>
        /// <remarks>
        /// If unspecified, defaults to 14400 seconds (4 hours).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#expires_after_seconds Invoice#expires_after_seconds}
        /// </remarks>
        [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAfterSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsPix), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Determines if the amount includes the IOF tax.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#amount_includes_iof Invoice#amount_includes_iof}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountIncludesIof
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of seconds after PaymentIntent confirmation when the Pix expires (between 60 and 1209600, inclusive).</summary>
            /// <remarks>
            /// If unspecified, defaults to 14400 seconds (4 hours).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#expires_after_seconds Invoice#expires_after_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAfterSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
