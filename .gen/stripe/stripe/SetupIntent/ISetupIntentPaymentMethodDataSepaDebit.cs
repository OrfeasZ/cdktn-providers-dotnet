using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataSepaDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit")]
    public interface ISetupIntentPaymentMethodDataSepaDebit
    {
        /// <summary>IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#iban SetupIntent#iban}
        /// </remarks>
        [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
        string Iban
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataSepaDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IBAN of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#iban SetupIntent#iban}
            /// </remarks>
            [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
            public string Iban
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
