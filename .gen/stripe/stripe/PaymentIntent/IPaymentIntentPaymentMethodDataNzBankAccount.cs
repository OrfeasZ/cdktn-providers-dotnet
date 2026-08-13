using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataNzBankAccount), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount")]
    public interface IPaymentIntentPaymentMethodDataNzBankAccount
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>The numeric code for the bank account's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank_code PaymentIntent#bank_code}
        /// </remarks>
        [JsiiProperty(name: "bankCode", typeJson: "{\"primitive\":\"string\"}")]
        string BankCode
        {
            get;
        }

        /// <summary>The numeric code for the bank account's bank branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#branch_code PaymentIntent#branch_code}
        /// </remarks>
        [JsiiProperty(name: "branchCode", typeJson: "{\"primitive\":\"string\"}")]
        string BranchCode
        {
            get;
        }

        /// <summary>The suffix of the bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#suffix PaymentIntent#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        /// <summary>The name on the bank account.</summary>
        /// <remarks>
        /// Only required if the account holder name is different from the name of the authorized signatory collected in the PaymentMethod’s billing details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_holder_name PaymentIntent#account_holder_name}
        /// </remarks>
        [JsiiProperty(name: "accountHolderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountHolderName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#reference PaymentIntent#reference}.</summary>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataNzBankAccount), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The numeric code for the bank account's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank_code PaymentIntent#bank_code}
            /// </remarks>
            [JsiiProperty(name: "bankCode", typeJson: "{\"primitive\":\"string\"}")]
            public string BankCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The numeric code for the bank account's bank branch.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#branch_code PaymentIntent#branch_code}
            /// </remarks>
            [JsiiProperty(name: "branchCode", typeJson: "{\"primitive\":\"string\"}")]
            public string BranchCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The suffix of the bank account number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#suffix PaymentIntent#suffix}
            /// </remarks>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name on the bank account.</summary>
            /// <remarks>
            /// Only required if the account holder name is different from the name of the authorized signatory collected in the PaymentMethod’s billing details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_holder_name PaymentIntent#account_holder_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountHolderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountHolderName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#reference PaymentIntent#reference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
