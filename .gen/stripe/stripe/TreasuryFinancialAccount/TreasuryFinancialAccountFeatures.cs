using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeatures")]
    public class TreasuryFinancialAccountFeatures : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeatures
    {
        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#card_issuing TreasuryFinancialAccount#card_issuing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuing\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing? CardIssuing
        {
            get;
            set;
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#deposit_insurance TreasuryFinancialAccount#deposit_insurance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "depositInsurance", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsurance\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance? DepositInsurance
        {
            get;
            set;
        }

        /// <summary>Settings related to Financial Addresses features on a Financial Account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#financial_addresses TreasuryFinancialAccount#financial_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "financialAddresses", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses? FinancialAddresses
        {
            get;
            set;
        }

        /// <summary>InboundTransfers contains inbound transfers features for a FinancialAccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_transfers TreasuryFinancialAccount#inbound_transfers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers? InboundTransfers
        {
            get;
            set;
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#intra_stripe_flows TreasuryFinancialAccount#intra_stripe_flows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intraStripeFlows", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows? IntraStripeFlows
        {
            get;
            set;
        }

        /// <summary>String representing the object's type. Objects of the same type share the same value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#object TreasuryFinancialAccount#object}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Object
        {
            get;
            set;
        }

        /// <summary>Settings related to Outbound Payments features on a Financial Account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_payments TreasuryFinancialAccount#outbound_payments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundPayments", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments? OutboundPayments
        {
            get;
            set;
        }

        /// <summary>OutboundTransfers contains outbound transfers features for a FinancialAccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_transfers TreasuryFinancialAccount#outbound_transfers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers? OutboundTransfers
        {
            get;
            set;
        }
    }
}
