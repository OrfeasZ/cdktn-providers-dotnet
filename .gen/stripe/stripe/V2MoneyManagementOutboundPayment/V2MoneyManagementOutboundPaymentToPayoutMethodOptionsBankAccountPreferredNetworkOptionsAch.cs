using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch")]
    public class V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch : stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch
    {
        /// <summary>Open Enum. ACH submission timing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#submission V2MoneyManagementOutboundPayment#submission}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#transaction_purpose V2MoneyManagementOutboundPayment#transaction_purpose}
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
