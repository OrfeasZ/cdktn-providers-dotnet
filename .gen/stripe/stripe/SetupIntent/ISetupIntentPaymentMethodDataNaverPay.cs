using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataNaverPay), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay")]
    public interface ISetupIntentPaymentMethodDataNaverPay
    {
        /// <summary>Whether to use Naver Pay points or a card to fund this transaction.</summary>
        /// <remarks>
        /// If not provided, this defaults to <c>card</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#funding SetupIntent#funding}
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataNaverPay), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to use Naver Pay points or a card to fund this transaction.</summary>
            /// <remarks>
            /// If not provided, this defaults to <c>card</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#funding SetupIntent#funding}
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
