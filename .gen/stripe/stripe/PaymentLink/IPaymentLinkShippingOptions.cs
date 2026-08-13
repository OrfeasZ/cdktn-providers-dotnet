using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkShippingOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkShippingOptions")]
    public interface IPaymentLinkShippingOptions
    {
        /// <summary>The ID of the Shipping Rate to use for this shipping option.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_rate PaymentLink#shipping_rate}
        /// </remarks>
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShippingRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkShippingOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkShippingOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkShippingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Shipping Rate to use for this shipping option.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_rate PaymentLink#shipping_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShippingRate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
