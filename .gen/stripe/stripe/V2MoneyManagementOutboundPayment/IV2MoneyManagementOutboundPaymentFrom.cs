using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementOutboundPaymentFrom), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom")]
    public interface IV2MoneyManagementOutboundPaymentFrom
    {
        /// <summary>Describes the FinancialAmount's currency drawn from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The FinancialAccount that funds were pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#financial_account V2MoneyManagementOutboundPayment#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        string FinancialAccount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementOutboundPaymentFrom), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes the FinancialAmount's currency drawn from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The FinancialAccount that funds were pulled from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#financial_account V2MoneyManagementOutboundPayment#financial_account}
            /// </remarks>
            [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
            public string FinancialAccount
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
