using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkPaymentMethodOptionsCardRestrictions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptionsCardRestrictions")]
    public interface IPaymentLinkPaymentMethodOptionsCardRestrictions
    {
        /// <summary>The card brands to block.</summary>
        /// <remarks>
        /// If a customer enters or selects a card belonging to a blocked brand, they can't complete the payment.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#brands_blocked PaymentLink#brands_blocked}
        /// </remarks>
        [JsiiProperty(name: "brandsBlocked", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BrandsBlocked
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkPaymentMethodOptionsCardRestrictions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPaymentMethodOptionsCardRestrictions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkPaymentMethodOptionsCardRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The card brands to block.</summary>
            /// <remarks>
            /// If a customer enters or selects a card belonging to a blocked brand, they can't complete the payment.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#brands_blocked PaymentLink#brands_blocked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "brandsBlocked", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BrandsBlocked
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
