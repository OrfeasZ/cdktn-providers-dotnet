using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerInvoiceSettings")]
    public class CustomerInvoiceSettings : stripe.Customer.ICustomerInvoiceSettings
    {
        private object? _customFields;

        /// <summary>Default custom fields to be displayed on invoices for this customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#custom_fields Customer#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case stripe.Customer.ICustomerInvoiceSettingsCustomFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerInvoiceSettingsCustomFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customFields = value;
            }
        }

        /// <summary>ID of a payment method that's attached to the customer, to be used as the customer's default payment method for subscriptions and invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#default_payment_method Customer#default_payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultPaymentMethod
        {
            get;
            set;
        }

        /// <summary>Default footer to be displayed on invoices for this customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#footer Customer#footer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Footer
        {
            get;
            set;
        }

        private object? _renderingOptions;

        /// <summary>rendering_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#rendering_options Customer#rendering_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerInvoiceSettingsRenderingOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RenderingOptions
        {
            get => _renderingOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Customer.ICustomerInvoiceSettingsRenderingOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerInvoiceSettingsRenderingOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _renderingOptions = value;
            }
        }
    }
}
