using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataBacsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit")]
    public interface ISetupIntentPaymentMethodDataBacsDebit
    {
        /// <summary>Account number of the bank account that the funds will be debited from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sort code of the bank account. (e.g., `10-20-30`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sort_code SetupIntent#sort_code}
        /// </remarks>
        [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataBacsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Account number of the bank account that the funds will be debited from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sort code of the bank account. (e.g., `10-20-30`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sort_code SetupIntent#sort_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
