using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiInterface(nativeType: typeof(ITreasuryFinancialAccountPlatformRestrictions), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountPlatformRestrictions")]
    public interface ITreasuryFinancialAccountPlatformRestrictions
    {
        /// <summary>Restricts all inbound money movement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_flows TreasuryFinancialAccount#inbound_flows}
        /// </remarks>
        [JsiiProperty(name: "inboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InboundFlows
        {
            get
            {
                return null;
            }
        }

        /// <summary>Restricts all outbound money movement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_flows TreasuryFinancialAccount#outbound_flows}
        /// </remarks>
        [JsiiProperty(name: "outboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundFlows
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITreasuryFinancialAccountPlatformRestrictions), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountPlatformRestrictions")]
        internal sealed class _Proxy : DeputyBase, stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountPlatformRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Restricts all inbound money movement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#inbound_flows TreasuryFinancialAccount#inbound_flows}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InboundFlows
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Restricts all outbound money movement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#outbound_flows TreasuryFinancialAccount#outbound_flows}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outboundFlows", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundFlows
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
