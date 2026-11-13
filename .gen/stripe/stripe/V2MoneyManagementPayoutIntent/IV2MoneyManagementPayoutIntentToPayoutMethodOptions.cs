using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentToPayoutMethodOptions), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptions")]
    public interface IV2MoneyManagementPayoutIntentToPayoutMethodOptions
    {
        /// <summary>Options for bank account payout methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#bank_account V2MoneyManagementPayoutIntent#bank_account}
        /// </remarks>
        [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount? BankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentToPayoutMethodOptions), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Options for bank account payout methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#bank_account V2MoneyManagementPayoutIntent#bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount\"}", isOptional: true)]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount? BankAccount
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount?>();
            }
        }
    }
}
