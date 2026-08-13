using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData")]
    public class PaymentLinkInvoiceCreationInvoiceData : stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData
    {
        /// <summary>The account tax IDs associated with the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#account_tax_ids PaymentLink#account_tax_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AccountTaxIds
        {
            get;
            set;
        }

        private object? _customFields;

        /// <summary>A list of up to 4 custom fields to be displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_fields PaymentLink#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomFields
        {
            get => _customFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customFields = value;
            }
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Footer to be displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#footer PaymentLink#footer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Footer
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Options for invoice PDF rendering.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#rendering_options PaymentLink#rendering_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions? RenderingOptions
        {
            get;
            set;
        }
    }
}
