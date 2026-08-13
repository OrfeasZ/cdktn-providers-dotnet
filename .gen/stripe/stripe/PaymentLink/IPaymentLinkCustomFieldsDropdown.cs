using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomFieldsDropdown), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsDropdown")]
    public interface IPaymentLinkCustomFieldsDropdown
    {
        /// <summary>The options available for the customer to select. Up to 200 options allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#options PaymentLink#options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdownOptions\"},\"kind\":\"array\"}}]}}")]
        object Options
        {
            get;
        }

        /// <summary>The value that pre-fills on the payment page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
        /// </remarks>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomFieldsDropdown), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsDropdown")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The options available for the customer to select. Up to 200 options allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#options PaymentLink#options}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdownOptions\"},\"kind\":\"array\"}}]}}")]
            public object Options
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The value that pre-fills on the payment page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
