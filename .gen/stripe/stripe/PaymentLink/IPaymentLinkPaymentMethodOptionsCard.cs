using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkPaymentMethodOptionsCard), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptionsCard")]
    public interface IPaymentLinkPaymentMethodOptionsCard
    {
        /// <summary>Restrictions to apply to the card payment method. For example, you can block specific card brands.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#restrictions PaymentLink#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsCardRestrictions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCardRestrictions? Restrictions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkPaymentMethodOptionsCard), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptionsCard")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Restrictions to apply to the card payment method. For example, you can block specific card brands.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#restrictions PaymentLink#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsCardRestrictions\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCardRestrictions? Restrictions
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCardRestrictions?>();
            }
        }
    }
}
