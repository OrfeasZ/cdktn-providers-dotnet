using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkPaymentMethodOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptions")]
    public interface IPaymentLinkPaymentMethodOptions
    {
        /// <summary>Configuration for `card` payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#card PaymentLink#card}
        /// </remarks>
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCard? Card
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkPaymentMethodOptions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkPaymentMethodOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration for `card` payment methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#card PaymentLink#card}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsCard\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCard? Card
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCard?>();
            }
        }
    }
}
