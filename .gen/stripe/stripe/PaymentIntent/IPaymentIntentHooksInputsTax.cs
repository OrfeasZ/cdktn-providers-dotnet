using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentHooksInputsTax), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooksInputsTax")]
    public interface IPaymentIntentHooksInputsTax
    {
        /// <summary>The [TaxCalculation](https://docs.stripe.com/api/tax/calculations) id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#calculation PaymentIntent#calculation}
        /// </remarks>
        [JsiiProperty(name: "calculation", typeJson: "{\"primitive\":\"string\"}")]
        string Calculation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentHooksInputsTax), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooksInputsTax")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentHooksInputsTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The [TaxCalculation](https://docs.stripe.com/api/tax/calculations) id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#calculation PaymentIntent#calculation}
            /// </remarks>
            [JsiiProperty(name: "calculation", typeJson: "{\"primitive\":\"string\"}")]
            public string Calculation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
