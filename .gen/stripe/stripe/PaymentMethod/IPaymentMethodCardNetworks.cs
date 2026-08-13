using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCardNetworks), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardNetworks")]
    public interface IPaymentMethodCardNetworks
    {
        /// <summary>The preferred network for co-branded cards.</summary>
        /// <remarks>
        /// Can be <c>cartes_bancaires</c>, <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not valid for the card.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#preferred PaymentMethod#preferred}
        /// </remarks>
        [JsiiProperty(name: "preferred", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Preferred
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCardNetworks), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardNetworks")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCardNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The preferred network for co-branded cards.</summary>
            /// <remarks>
            /// Can be <c>cartes_bancaires</c>, <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not valid for the card.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#preferred PaymentMethod#preferred}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferred", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Preferred
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
