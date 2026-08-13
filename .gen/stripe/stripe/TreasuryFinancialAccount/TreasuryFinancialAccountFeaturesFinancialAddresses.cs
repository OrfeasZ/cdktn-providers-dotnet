using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses")]
    public class TreasuryFinancialAccountFeaturesFinancialAddresses : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses
    {
        /// <summary>Toggle settings for enabling/disabling the ABA address feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#aba TreasuryFinancialAccount#aba}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aba", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesAba\"}", isOptional: true)]
        public stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddressesAba? Aba
        {
            get;
            set;
        }
    }
}
