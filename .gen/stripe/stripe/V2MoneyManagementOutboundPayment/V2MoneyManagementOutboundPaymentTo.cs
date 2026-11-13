using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo")]
    public class V2MoneyManagementOutboundPaymentTo : stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo
    {
        /// <summary>To which account the OutboundPayment is sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient V2MoneyManagementOutboundPayment#recipient}
        /// </remarks>
        [JsiiProperty(name: "recipient", typeJson: "{\"primitive\":\"string\"}")]
        public string Recipient
        {
            get;
            set;
        }

        /// <summary>Describes the currency to send to the recipient.</summary>
        /// <remarks>
        /// If included, this currency must match a currency supported by the destination.
        /// Can be omitted in the following cases:
        ///
        /// <list type="bullet">
        /// <description>destination only supports one currency</description>
        /// <description>destination supports multiple currencies and one matches <c>from.currency</c></description>
        /// <description>destination supports multiple currencies and one matches <c>amount.currency</c>
        /// When both <c>from.currency</c> and <c>amount.currency</c> are supported, Stripe selects <c>from.currency</c> to minimize currency conversion.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>The payout method which the OutboundPayment uses to send payout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method V2MoneyManagementOutboundPayment#payout_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayoutMethod
        {
            get;
            set;
        }

        /// <summary>Payout method options for the OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method_options V2MoneyManagementOutboundPayment#payout_method_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payoutMethodOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptions\"}", isOptional: true)]
        public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptions? PayoutMethodOptions
        {
            get;
            set;
        }
    }
}
