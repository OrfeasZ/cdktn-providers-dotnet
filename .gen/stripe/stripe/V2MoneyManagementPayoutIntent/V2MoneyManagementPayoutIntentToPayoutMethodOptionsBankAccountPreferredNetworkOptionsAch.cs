using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch")]
    public class V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch
    {
        /// <summary>Open Enum. ACH submission timing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#submission V2MoneyManagementPayoutIntent#submission}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "submission", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Submission
        {
            get;
            set;
        }

        /// <summary>The transaction purpose for this ACH payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#transaction_purpose V2MoneyManagementPayoutIntent#transaction_purpose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transactionPurpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransactionPurpose
        {
            get;
            set;
        }
    }
}
