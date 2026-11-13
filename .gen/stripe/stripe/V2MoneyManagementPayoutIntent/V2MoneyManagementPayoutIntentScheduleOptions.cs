using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions")]
    public class V2MoneyManagementPayoutIntentScheduleOptions : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions
    {
        /// <summary>The date when the payout should be executed, in YYYY-MM-DD format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#execute_on V2MoneyManagementPayoutIntent#execute_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executeOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecuteOn
        {
            get;
            set;
        }
    }
}
