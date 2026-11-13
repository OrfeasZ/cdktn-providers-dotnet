using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions")]
    public class V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions : stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions
    {
        /// <summary>ACH-specific network options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#ach V2MoneyManagementOutboundPayment#ach}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch\"}", isOptional: true)]
        public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch? Ach
        {
            get;
            set;
        }
    }
}
