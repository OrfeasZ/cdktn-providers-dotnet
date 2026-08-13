using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodNaverPay), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodNaverPay")]
    public interface IPaymentMethodNaverPay
    {
        /// <summary>Whether to fund this transaction with Naver Pay points or a card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#funding PaymentMethod#funding}
        /// </remarks>
        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Funding
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodNaverPay), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodNaverPay")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodNaverPay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to fund this transaction with Naver Pay points or a card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#funding PaymentMethod#funding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Funding
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
