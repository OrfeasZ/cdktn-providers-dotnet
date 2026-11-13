using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom")]
    public class V2MoneyManagementPayoutIntentFrom : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom
    {
        /// <summary>The currency of the financial account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#currency V2MoneyManagementPayoutIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>The FinancialAccount that funds are pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#financial_account V2MoneyManagementPayoutIntent#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        public string FinancialAccount
        {
            get;
            set;
        }
    }
}
