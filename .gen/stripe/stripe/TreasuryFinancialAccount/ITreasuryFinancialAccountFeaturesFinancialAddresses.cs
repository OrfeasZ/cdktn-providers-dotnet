using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountFeaturesFinancialAddresses), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses")]
    public interface ITreasuryFinancialAccountFeaturesFinancialAddresses
    {
        /// <summary>Toggle settings for enabling/disabling the ABA address feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#aba TreasuryFinancialAccount#aba}
        /// </remarks>
        [JsiiProperty(name: "aba", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesAba\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddressesAba? Aba
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountFeaturesFinancialAddresses), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Toggle settings for enabling/disabling the ABA address feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#aba TreasuryFinancialAccount#aba}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aba", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesAba\"}", isOptional: true)]
            public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddressesAba? Aba
            {
                get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddressesAba?>();
            }
        }
    }
}
