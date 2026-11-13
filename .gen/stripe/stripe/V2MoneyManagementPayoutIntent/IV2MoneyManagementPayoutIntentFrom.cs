using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentFrom), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom")]
    public interface IV2MoneyManagementPayoutIntentFrom
    {
        /// <summary>The currency of the financial account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#currency V2MoneyManagementPayoutIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The FinancialAccount that funds are pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#financial_account V2MoneyManagementPayoutIntent#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        string FinancialAccount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentFrom), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency of the financial account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#currency V2MoneyManagementPayoutIntent#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The FinancialAccount that funds are pulled from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#financial_account V2MoneyManagementPayoutIntent#financial_account}
            /// </remarks>
            [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
            public string FinancialAccount
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
