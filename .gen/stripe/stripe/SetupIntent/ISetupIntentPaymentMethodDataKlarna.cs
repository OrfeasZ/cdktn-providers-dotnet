using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataKlarna), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataKlarna")]
    public interface ISetupIntentPaymentMethodDataKlarna
    {
        /// <summary>Customer's date of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#dob SetupIntent#dob}
        /// </remarks>
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob? Dob
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataKlarna), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataKlarna")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Customer's date of birth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#dob SetupIntent#dob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob? Dob
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob?>();
            }
        }
    }
}
