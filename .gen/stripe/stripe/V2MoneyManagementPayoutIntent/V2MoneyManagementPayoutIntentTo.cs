using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentTo")]
    public class V2MoneyManagementPayoutIntentTo : stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo
    {
        /// <summary>The currency to send to the recipient.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#currency V2MoneyManagementPayoutIntent#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>The payout method ID for the PayoutIntent.</summary>
        /// <remarks>
        /// Optional when the PayoutIntent creates an OutboundPayment and the recipient has a default payout method. Required when the PayoutIntent creates an OutboundTransfer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#payout_method V2MoneyManagementPayoutIntent#payout_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayoutMethod
        {
            get;
            set;
        }

        /// <summary>Payout method options for the PayoutIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#payout_method_options V2MoneyManagementPayoutIntent#payout_method_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payoutMethodOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptions\"}", isOptional: true)]
        public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptions? PayoutMethodOptions
        {
            get;
            set;
        }

        /// <summary>The recipient ID for the PayoutIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#recipient V2MoneyManagementPayoutIntent#recipient}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recipient", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Recipient
        {
            get;
            set;
        }
    }
}
