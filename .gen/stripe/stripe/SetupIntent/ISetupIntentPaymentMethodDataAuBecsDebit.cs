using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataAuBecsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit")]
    public interface ISetupIntentPaymentMethodDataAuBecsDebit
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Bank-State-Branch number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bsb_number SetupIntent#bsb_number}
        /// </remarks>
        [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
        string BsbNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataAuBecsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Bank-State-Branch number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bsb_number SetupIntent#bsb_number}
            /// </remarks>
            [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string BsbNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
