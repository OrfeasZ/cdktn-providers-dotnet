using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataP24), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataP24")]
    public interface IPaymentIntentPaymentMethodDataP24
    {
        /// <summary>The customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank PaymentIntent#bank}
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

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataP24), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataP24")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank PaymentIntent#bank}
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
