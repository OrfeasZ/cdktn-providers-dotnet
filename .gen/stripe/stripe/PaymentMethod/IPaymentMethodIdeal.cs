using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodIdeal), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodIdeal")]
    public interface IPaymentMethodIdeal
    {
        /// <summary>The customer's bank, if provided.</summary>
        /// <remarks>
        /// Can be one of <c>abn_amro</c>, <c>adyen</c>, <c>asn_bank</c>, <c>bunq</c>, <c>buut</c>, <c>finom</c>, <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>mollie</c>, <c>moneyou</c>, <c>n26</c>, <c>nn</c>, <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>, <c>triodos_bank</c>, <c>van_lanschot</c>, or <c>yoursafe</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank PaymentMethod#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bank
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodIdeal), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodIdeal")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodIdeal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank, if provided.</summary>
            /// <remarks>
            /// Can be one of <c>abn_amro</c>, <c>adyen</c>, <c>asn_bank</c>, <c>bunq</c>, <c>buut</c>, <c>finom</c>, <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>mollie</c>, <c>moneyou</c>, <c>n26</c>, <c>nn</c>, <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>, <c>triodos_bank</c>, <c>van_lanschot</c>, or <c>yoursafe</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank PaymentMethod#bank}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bank
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
