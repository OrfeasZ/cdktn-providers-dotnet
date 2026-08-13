using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomFieldsDropdown")]
    public class PaymentLinkCustomFieldsDropdown : stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown
    {
        private object _options;

        /// <summary>The options available for the customer to select. Up to 200 options allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#options PaymentLink#options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdownOptions\"},\"kind\":\"array\"}}]}}")]
        public object Options
        {
            get => _options;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _options = value;
            }
        }

        /// <summary>The value that pre-fills on the payment page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultValue
        {
            get;
            set;
        }
    }
}
