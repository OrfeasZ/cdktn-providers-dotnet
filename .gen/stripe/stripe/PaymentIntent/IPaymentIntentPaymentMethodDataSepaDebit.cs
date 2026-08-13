using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataSepaDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit")]
    public interface IPaymentIntentPaymentMethodDataSepaDebit
    {
        /// <summary>IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#iban PaymentIntent#iban}
        /// </remarks>
        [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
        string Iban
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataSepaDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IBAN of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#iban PaymentIntent#iban}
            /// </remarks>
            [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
            public string Iban
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
