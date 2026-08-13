using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodSepaDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodSepaDebit")]
    public interface IPaymentMethodSepaDebit
    {
        /// <summary>IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#iban PaymentMethod#iban}
        /// </remarks>
        [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
        string Iban
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodSepaDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodSepaDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodSepaDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IBAN of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#iban PaymentMethod#iban}
            /// </remarks>
            [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
            public string Iban
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
