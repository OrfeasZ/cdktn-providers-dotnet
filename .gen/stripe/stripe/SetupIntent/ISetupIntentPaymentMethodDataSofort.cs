using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataSofort), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataSofort")]
    public interface ISetupIntentPaymentMethodDataSofort
    {
        /// <summary>Two-letter ISO code representing the country the bank account is located in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#country SetupIntent#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        string Country
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataSofort), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataSofort")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Two-letter ISO code representing the country the bank account is located in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#country SetupIntent#country}
            /// </remarks>
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
            public string Country
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
