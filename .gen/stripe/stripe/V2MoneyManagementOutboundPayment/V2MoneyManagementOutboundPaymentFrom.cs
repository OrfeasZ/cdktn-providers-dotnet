using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom")]
    public class V2MoneyManagementOutboundPaymentFrom : stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom
    {
        /// <summary>Describes the FinancialAmount's currency drawn from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>The FinancialAccount that funds were pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#financial_account V2MoneyManagementOutboundPayment#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        public string FinancialAccount
        {
            get;
            set;
        }
    }
}
