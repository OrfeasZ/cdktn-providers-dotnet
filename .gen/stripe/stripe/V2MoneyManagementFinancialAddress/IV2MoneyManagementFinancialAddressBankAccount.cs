using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementFinancialAddressBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount")]
    public interface IV2MoneyManagementFinancialAddressBankAccount
    {
        /// <summary>Open Enum. The currency of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#currency V2MoneyManagementFinancialAddress#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The country of the bank account.</summary>
        /// <remarks>
        /// Always included in the response, but null while the bank
        /// account is pending and its country is not yet known.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#country V2MoneyManagementFinancialAddress#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementFinancialAddressBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Open Enum. The currency of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#currency V2MoneyManagementFinancialAddress#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The country of the bank account.</summary>
            /// <remarks>
            /// Always included in the response, but null while the bank
            /// account is pending and its country is not yet known.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#country V2MoneyManagementFinancialAddress#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
