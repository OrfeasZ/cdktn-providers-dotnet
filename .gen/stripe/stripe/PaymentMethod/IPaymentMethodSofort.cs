using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodSofort), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodSofort")]
    public interface IPaymentMethodSofort
    {
        /// <summary>Two-letter ISO code representing the country the bank account is located in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#country PaymentMethod#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        string Country
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodSofort), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodSofort")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodSofort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Two-letter ISO code representing the country the bank account is located in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#country PaymentMethod#country}
            /// </remarks>
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
            public string Country
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
