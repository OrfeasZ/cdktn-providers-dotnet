using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountFeatures), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeatures")]
    public interface ITreasuryFinancialAccountFeatures
    {
        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#card_issuing TreasuryFinancialAccount#card_issuing}
        /// </remarks>
        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing? CardIssuing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#deposit_insurance TreasuryFinancialAccount#deposit_insurance}
        /// </remarks>
        [JsiiProperty(name: "depositInsurance", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsurance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance? DepositInsurance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings related to Financial Addresses features on a Financial Account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#financial_addresses TreasuryFinancialAccount#financial_addresses}
        /// </remarks>
        [JsiiProperty(name: "financialAddresses", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses? FinancialAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>InboundTransfers contains inbound transfers features for a FinancialAccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_transfers TreasuryFinancialAccount#inbound_transfers}
        /// </remarks>
        [JsiiProperty(name: "inboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers? InboundTransfers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#intra_stripe_flows TreasuryFinancialAccount#intra_stripe_flows}
        /// </remarks>
        [JsiiProperty(name: "intraStripeFlows", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows? IntraStripeFlows
        {
            get
            {
                return null;
            }
        }

        /// <summary>String representing the object's type. Objects of the same type share the same value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#object TreasuryFinancialAccount#object}
        /// </remarks>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Object
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings related to Outbound Payments features on a Financial Account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_payments TreasuryFinancialAccount#outbound_payments}
        /// </remarks>
        [JsiiProperty(name: "outboundPayments", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments? OutboundPayments
        {
            get
            {
                return null;
            }
        }

        /// <summary>OutboundTransfers contains outbound transfers features for a FinancialAccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_transfers TreasuryFinancialAccount#outbound_transfers}
        /// </remarks>
        [JsiiProperty(name: "outboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers? OutboundTransfers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountFeatures), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeatures")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Toggle settings for enabling/disabling a feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#card_issuing TreasuryFinancialAccount#card_issuing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuing\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing? CardIssuing
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing?>();
            }

            /// <summary>Toggle settings for enabling/disabling a feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#deposit_insurance TreasuryFinancialAccount#deposit_insurance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "depositInsurance", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsurance\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance? DepositInsurance
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance?>();
            }

            /// <summary>Settings related to Financial Addresses features on a Financial Account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#financial_addresses TreasuryFinancialAccount#financial_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "financialAddresses", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses? FinancialAddresses
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses?>();
            }

            /// <summary>InboundTransfers contains inbound transfers features for a FinancialAccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_transfers TreasuryFinancialAccount#inbound_transfers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers? InboundTransfers
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers?>();
            }

            /// <summary>Toggle settings for enabling/disabling a feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#intra_stripe_flows TreasuryFinancialAccount#intra_stripe_flows}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intraStripeFlows", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows? IntraStripeFlows
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows?>();
            }

            /// <summary>String representing the object's type. Objects of the same type share the same value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#object TreasuryFinancialAccount#object}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Object
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Settings related to Outbound Payments features on a Financial Account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_payments TreasuryFinancialAccount#outbound_payments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outboundPayments", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments? OutboundPayments
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments?>();
            }

            /// <summary>OutboundTransfers contains outbound transfers features for a FinancialAccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_transfers TreasuryFinancialAccount#outbound_transfers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers? OutboundTransfers
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers?>();
            }
        }
    }
}
