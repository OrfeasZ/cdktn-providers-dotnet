using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountFeaturesIntraStripeFlows), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows")]
    public interface ITreasuryFinancialAccountFeaturesIntraStripeFlows
    {
        /// <summary>Whether the FinancialAccount should have the Feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#requested TreasuryFinancialAccount#requested}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Requested
        {
            get;
        }

        /// <summary>Whether the Feature is operational.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status TreasuryFinancialAccount#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional details; includes at least one entry when the status is not `active`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status_details TreasuryFinancialAccount#status_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlowsStatusDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "statusDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlowsStatusDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountFeaturesIntraStripeFlows), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the FinancialAccount should have the Feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#requested TreasuryFinancialAccount#requested}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "requested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Requested
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Whether the Feature is operational.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status TreasuryFinancialAccount#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional details; includes at least one entry when the status is not `active`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status_details TreasuryFinancialAccount#status_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlowsStatusDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlowsStatusDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
