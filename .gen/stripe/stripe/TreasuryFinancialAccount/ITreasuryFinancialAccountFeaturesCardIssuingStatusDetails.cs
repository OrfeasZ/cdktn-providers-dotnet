using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountFeaturesCardIssuingStatusDetails), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuingStatusDetails")]
    public interface ITreasuryFinancialAccountFeaturesCardIssuingStatusDetails
    {
        /// <summary>Represents the reason why the status is `pending` or `restricted`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#code TreasuryFinancialAccount#code}
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents what the user should do, if anything, to activate the Feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#resolution TreasuryFinancialAccount#resolution}
        /// </remarks>
        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>The `platform_restrictions` that are restricting this Feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#restriction TreasuryFinancialAccount#restriction}
        /// </remarks>
        [JsiiProperty(name: "restriction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Restriction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountFeaturesCardIssuingStatusDetails), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuingStatusDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuingStatusDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Represents the reason why the status is `pending` or `restricted`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#code TreasuryFinancialAccount#code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Code
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Represents what the user should do, if anything, to activate the Feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#resolution TreasuryFinancialAccount#resolution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resolution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The `platform_restrictions` that are restricting this Feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#restriction TreasuryFinancialAccount#restriction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restriction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Restriction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
