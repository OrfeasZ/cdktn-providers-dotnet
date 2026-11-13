using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementInboundTransfer
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementInboundTransferTo), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferTo")]
    public interface IV2MoneyManagementInboundTransferTo
    {
        /// <summary>The currency to credit to the FinancialAccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#currency V2MoneyManagementInboundTransfer#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The FinancialAccount that funds will land in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#financial_account V2MoneyManagementInboundTransfer#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        string FinancialAccount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementInboundTransferTo), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferTo")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferTo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency to credit to the FinancialAccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#currency V2MoneyManagementInboundTransfer#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The FinancialAccount that funds will land in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#financial_account V2MoneyManagementInboundTransfer#financial_account}
            /// </remarks>
            [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
            public string FinancialAccount
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
