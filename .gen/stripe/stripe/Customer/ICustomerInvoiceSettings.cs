using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerInvoiceSettings), fullyQualifiedName: "stripe.customer.CustomerInvoiceSettings")]
    public interface ICustomerInvoiceSettings
    {
        /// <summary>Default custom fields to be displayed on invoices for this customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#custom_fields Customer#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsCustomFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#default_payment_method Customer#default_payment_method}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#footer Customer#footer}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#rendering_options Customer#rendering_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsRenderingOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenderingOptions
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

            /// <summary>Default custom fields to be displayed on invoices for this customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#custom_fields Customer#custom_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsCustomFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of a payment method that's attached to the customer, to be used as the customer's default payment method for subscriptions and invoices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#default_payment_method Customer#default_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultPaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Default footer to be displayed on invoices for this customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#footer Customer#footer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Footer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rendering_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#rendering_options Customer#rendering_options}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsRenderingOptions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renderingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RenderingOptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
