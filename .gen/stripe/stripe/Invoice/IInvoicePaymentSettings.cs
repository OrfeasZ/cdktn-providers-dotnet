using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettings), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettings")]
    public interface IInvoicePaymentSettings
    {
        /// <summary>ID of the mandate to be used for this invoice.</summary>
        /// <remarks>
        /// It must correspond to the payment method used to pay the invoice, including the invoice's default_payment_method or default_source, if set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_mandate Invoice#default_mandate}
        /// </remarks>
        [JsiiProperty(name: "defaultMandate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultMandate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Payment-method-specific configuration to provide to the invoice’s PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_method_options Invoice#payment_method_options}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions? PaymentMethodOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of payment method types (e.g. card) to provide to the invoice’s PaymentIntent. If not set, Stripe attempts to automatically determine the types to use by looking at the invoice’s default payment method, the subscription’s default payment method, the customer’s default payment method, and your [invoice template settings](https://dashboard.stripe.com/settings/billing/invoice).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_method_types Invoice#payment_method_types}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PaymentMethodTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettings), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the mandate to be used for this invoice.</summary>
            /// <remarks>
            /// It must correspond to the payment method used to pay the invoice, including the invoice's default_payment_method or default_source, if set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_mandate Invoice#default_mandate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultMandate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultMandate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Payment-method-specific configuration to provide to the invoice’s PaymentIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_method_options Invoice#payment_method_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptions\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions? PaymentMethodOptions
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions?>();
            }

            /// <summary>The list of payment method types (e.g. card) to provide to the invoice’s PaymentIntent. If not set, Stripe attempts to automatically determine the types to use by looking at the invoice’s default payment method, the subscription’s default payment method, the customer’s default payment method, and your [invoice template settings](https://dashboard.stripe.com/settings/billing/invoice).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_method_types Invoice#payment_method_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PaymentMethodTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
