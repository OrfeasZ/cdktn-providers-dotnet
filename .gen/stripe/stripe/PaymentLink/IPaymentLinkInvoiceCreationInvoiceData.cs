using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkInvoiceCreationInvoiceData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData")]
    public interface IPaymentLinkInvoiceCreationInvoiceData
    {
        /// <summary>The account tax IDs associated with the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#account_tax_ids PaymentLink#account_tax_ids}
        /// </remarks>
        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccountTaxIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of up to 4 custom fields to be displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_fields PaymentLink#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Footer to be displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#footer PaymentLink#footer}
        /// </remarks>
        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Footer
        {
            get
            {
                return null;
            }
        }

        /// <summary>The connected account that issues the invoice.</summary>
        /// <remarks>
        /// The invoice is presented with the branding and support information of the specified account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#issuer PaymentLink#issuer}
        /// </remarks>
        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer? Issuer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options for invoice PDF rendering.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#rendering_options PaymentLink#rendering_options}
        /// </remarks>
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions? RenderingOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkInvoiceCreationInvoiceData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account tax IDs associated with the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#account_tax_ids PaymentLink#account_tax_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccountTaxIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of up to 4 custom fields to be displayed on the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_fields PaymentLink#custom_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Footer to be displayed on the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#footer PaymentLink#footer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Footer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The connected account that issues the invoice.</summary>
            /// <remarks>
            /// The invoice is presented with the branding and support information of the specified account.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#issuer PaymentLink#issuer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuer\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer? Issuer
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Options for invoice PDF rendering.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#rendering_options PaymentLink#rendering_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions? RenderingOptions
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions?>();
            }
        }
    }
}
