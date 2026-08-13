using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkOptionalItemsAdjustableQuantity), fullyQualifiedName: "stripe.paymentLink.PaymentLinkOptionalItemsAdjustableQuantity")]
    public interface IPaymentLinkOptionalItemsAdjustableQuantity
    {
        /// <summary>Set to true if the quantity can be adjusted to any non-negative integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The maximum quantity of this item the customer can purchase. By default this value is 99.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#maximum PaymentLink#maximum}
        /// </remarks>
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Maximum
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum quantity of this item the customer must purchase, if they choose to purchase it.</summary>
        /// <remarks>
        /// Because this item is optional, the customer will always be able to remove it from their order, even if the <c>minimum</c> configured here is greater than 0. By default this value is 0.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#minimum PaymentLink#minimum}
        /// </remarks>
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minimum
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkOptionalItemsAdjustableQuantity), fullyQualifiedName: "stripe.paymentLink.PaymentLinkOptionalItemsAdjustableQuantity")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkOptionalItemsAdjustableQuantity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set to true if the quantity can be adjusted to any non-negative integer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The maximum quantity of this item the customer can purchase. By default this value is 99.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#maximum PaymentLink#maximum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Maximum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum quantity of this item the customer must purchase, if they choose to purchase it.</summary>
            /// <remarks>
            /// Because this item is optional, the customer will always be able to remove it from their order, even if the <c>minimum</c> configured here is greater than 0. By default this value is 0.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#minimum PaymentLink#minimum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minimum
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
