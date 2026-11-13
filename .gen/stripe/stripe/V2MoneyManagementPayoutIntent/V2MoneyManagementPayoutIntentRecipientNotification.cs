using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification")]
    public class V2MoneyManagementPayoutIntentRecipientNotification : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification
    {
        /// <summary>Closed Enum.</summary>
        /// <remarks>
        /// Configuration option to enable or disable notifications to recipients.
        /// Do not send notifications when <c>setting</c> is <c>none</c>. Use the account setting when <c>setting</c> is <c>configured</c> or omitted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#setting V2MoneyManagementPayoutIntent#setting}
        /// </remarks>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        public string Setting
        {
            get;
            set;
        }
    }
}
