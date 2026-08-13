using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountPlatformRestrictions")]
    public class TreasuryFinancialAccountPlatformRestrictions : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountPlatformRestrictions
    {
        /// <summary>Restricts all inbound money movement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_flows TreasuryFinancialAccount#inbound_flows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InboundFlows
        {
            get;
            set;
        }

        /// <summary>Restricts all outbound money movement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_flows TreasuryFinancialAccount#outbound_flows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundFlows
        {
            get;
            set;
        }
    }
}
