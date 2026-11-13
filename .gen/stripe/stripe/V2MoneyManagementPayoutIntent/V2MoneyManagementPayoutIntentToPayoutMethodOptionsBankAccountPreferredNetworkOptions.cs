using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions")]
    public class V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions
    {
        /// <summary>ACH-specific network options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#ach V2MoneyManagementPayoutIntent#ach}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch\"}", isOptional: true)]
        public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch? Ach
        {
            get;
            set;
        }
    }
}
