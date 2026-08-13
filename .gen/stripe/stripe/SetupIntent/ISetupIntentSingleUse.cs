using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentSingleUse), fullyQualifiedName: "stripe.setupIntent.SetupIntentSingleUse")]
    public interface ISetupIntentSingleUse
    {
        /// <summary>Amount the customer is granting permission to collect later.</summary>
        /// <remarks>
        /// A positive integer representing how much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum amount is $0.50 US or <a href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent in charge currency</a>. The amount value supports up to eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentSingleUse), fullyQualifiedName: "stripe.setupIntent.SetupIntentSingleUse")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentSingleUse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount the customer is granting permission to collect later.</summary>
            /// <remarks>
            /// A positive integer representing how much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum amount is $0.50 US or <a href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent in charge currency</a>. The amount value supports up to eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
