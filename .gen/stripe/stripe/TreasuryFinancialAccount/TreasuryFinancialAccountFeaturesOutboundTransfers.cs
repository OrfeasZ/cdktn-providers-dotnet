using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers")]
    public class TreasuryFinancialAccountFeaturesOutboundTransfers : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers
    {
        /// <summary>Toggle settings for enabling/disabling an outbound ACH specific feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#ach TreasuryFinancialAccount#ach}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAch\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersAch? Ach
        {
            get;
            set;
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#us_domestic_wire TreasuryFinancialAccount#us_domestic_wire}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usDomesticWire", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire? UsDomesticWire
        {
            get;
            set;
        }
    }
}
