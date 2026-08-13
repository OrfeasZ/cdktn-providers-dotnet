using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataAcssDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit")]
    public interface ISetupIntentPaymentMethodDataAcssDebit
    {
        /// <summary>Customer's bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Institution number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#institution_number SetupIntent#institution_number}
        /// </remarks>
        [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
        string InstitutionNumber
        {
            get;
        }

        /// <summary>Transit number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#transit_number SetupIntent#transit_number}
        /// </remarks>
        [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
        string TransitNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataAcssDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Customer's bank account number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Institution number of the customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#institution_number SetupIntent#institution_number}
            /// </remarks>
            [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string InstitutionNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Transit number of the customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#transit_number SetupIntent#transit_number}
            /// </remarks>
            [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
