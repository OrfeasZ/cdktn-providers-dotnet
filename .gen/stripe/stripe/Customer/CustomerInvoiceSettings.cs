using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerInvoiceSettings")]
    public class CustomerInvoiceSettings : stripe.Customer.ICustomerInvoiceSettings
    {
        private object? _customFields;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#custom_fields Customer#custom_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case string[][] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, string[][]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customFields = value;
            }
        }

        /// <summary>ID of a payment method that's attached to the customer, to be used as the customer's default payment method for subscriptions and invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#default_payment_method Customer#default_payment_method}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#footer Customer#footer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Footer
        {
            get;
            set;
        }

        /// <summary>rendering_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#rendering_options Customer#rendering_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}", isOptional: true)]
        public stripe.Customer.ICustomerInvoiceSettingsRenderingOptions? RenderingOptions
        {
            get;
            set;
        }
    }
}
