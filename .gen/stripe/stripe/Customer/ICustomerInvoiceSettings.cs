using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerInvoiceSettings), fullyQualifiedName: "stripe.customer.CustomerInvoiceSettings")]
    public interface ICustomerInvoiceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#custom_fields Customer#custom_fields}.</summary>
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of a payment method that's attached to the customer, to be used as the customer's default payment method for subscriptions and invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#default_payment_method Customer#default_payment_method}
        /// </remarks>
        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultPaymentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Default footer to be displayed on invoices for this customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#footer Customer#footer}
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

        /// <summary>rendering_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#rendering_options Customer#rendering_options}
        /// </remarks>
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerInvoiceSettingsRenderingOptions? RenderingOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerInvoiceSettings), fullyQualifiedName: "stripe.customer.CustomerInvoiceSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerInvoiceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#custom_fields Customer#custom_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of a payment method that's attached to the customer, to be used as the customer's default payment method for subscriptions and invoices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#default_payment_method Customer#default_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultPaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Default footer to be displayed on invoices for this customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#footer Customer#footer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Footer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rendering_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#rendering_options Customer#rendering_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}", isOptional: true)]
            public stripe.Customer.ICustomerInvoiceSettingsRenderingOptions? RenderingOptions
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettingsRenderingOptions?>();
            }
        }
    }
}
