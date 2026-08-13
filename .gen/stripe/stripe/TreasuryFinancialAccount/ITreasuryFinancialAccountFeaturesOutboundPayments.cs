using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountFeaturesOutboundPayments), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments")]
    public interface ITreasuryFinancialAccountFeaturesOutboundPayments
    {
        /// <summary>Toggle settings for enabling/disabling an outbound ACH specific feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#ach TreasuryFinancialAccount#ach}
        /// </remarks>
        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch? Ach
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggle settings for enabling/disabling a feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#us_domestic_wire TreasuryFinancialAccount#us_domestic_wire}
        /// </remarks>
        [JsiiProperty(name: "usDomesticWire", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire? UsDomesticWire
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountFeaturesOutboundPayments), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Toggle settings for enabling/disabling an outbound ACH specific feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#ach TreasuryFinancialAccount#ach}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAch\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch? Ach
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch?>();
            }

            /// <summary>Toggle settings for enabling/disabling a feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#us_domestic_wire TreasuryFinancialAccount#us_domestic_wire}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usDomesticWire", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire? UsDomesticWire
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire?>();
            }
        }
    }
}
