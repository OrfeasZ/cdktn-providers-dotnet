using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundSetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData")]
    public class V2MoneyManagementOutboundSetupIntentPayoutMethodData : stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData
    {
        /// <summary>Open Enum. The type of payout method to be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#type V2MoneyManagementOutboundSetupIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The type specific details of the bank account payout method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#bank_account V2MoneyManagementOutboundSetupIntent#bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount\"}", isOptional: true)]
        public stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount? BankAccount
        {
            get;
            set;
        }
    }
}
