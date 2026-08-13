using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers")]
    public class TreasuryFinancialAccountFeaturesInboundTransfers : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers
    {
        /// <summary>Toggle settings for enabling/disabling an inbound ACH specific feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#ach TreasuryFinancialAccount#ach}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfersAch\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfersAch? Ach
        {
            get;
            set;
        }
    }
}
