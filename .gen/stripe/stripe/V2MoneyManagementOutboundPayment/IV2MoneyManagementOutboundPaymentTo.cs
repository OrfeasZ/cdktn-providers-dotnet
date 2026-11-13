using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementOutboundPaymentTo), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo")]
    public interface IV2MoneyManagementOutboundPaymentTo
    {
        /// <summary>To which account the OutboundPayment is sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient V2MoneyManagementOutboundPayment#recipient}
        /// </remarks>
        [JsiiProperty(name: "recipient", typeJson: "{\"primitive\":\"string\"}")]
        string Recipient
        {
            get;
        }

        /// <summary>Describes the currency to send to the recipient.</summary>
        /// <remarks>
        /// If included, this currency must match a currency supported by the destination.
        /// Can be omitted in the following cases:
        ///
        /// <list type="bullet">
        /// <description>destination only supports one currency</description>
        /// <description>destination supports multiple currencies and one matches <c>from.currency</c></description>
        /// <description>destination supports multiple currencies and one matches <c>amount.currency</c>
        /// When both <c>from.currency</c> and <c>amount.currency</c> are supported, Stripe selects <c>from.currency</c> to minimize currency conversion.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>The payout method which the OutboundPayment uses to send payout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method V2MoneyManagementOutboundPayment#payout_method}
        /// </remarks>
        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayoutMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Payout method options for the OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method_options V2MoneyManagementOutboundPayment#payout_method_options}
        /// </remarks>
        [JsiiProperty(name: "payoutMethodOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptions? PayoutMethodOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementOutboundPaymentTo), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>To which account the OutboundPayment is sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient V2MoneyManagementOutboundPayment#recipient}
            /// </remarks>
            [JsiiProperty(name: "recipient", typeJson: "{\"primitive\":\"string\"}")]
            public string Recipient
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Describes the currency to send to the recipient.</summary>
            /// <remarks>
            /// If included, this currency must match a currency supported by the destination.
            /// Can be omitted in the following cases:
            ///
            /// <list type="bullet">
            /// <description>destination only supports one currency</description>
            /// <description>destination supports multiple currencies and one matches <c>from.currency</c></description>
            /// <description>destination supports multiple currencies and one matches <c>amount.currency</c>
            /// When both <c>from.currency</c> and <c>amount.currency</c> are supported, Stripe selects <c>from.currency</c> to minimize currency conversion.</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#currency V2MoneyManagementOutboundPayment#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The payout method which the OutboundPayment uses to send payout.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method V2MoneyManagementOutboundPayment#payout_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayoutMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Payout method options for the OutboundPayment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#payout_method_options V2MoneyManagementOutboundPayment#payout_method_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payoutMethodOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptions\"}", isOptional: true)]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptions? PayoutMethodOptions
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptions?>();
            }
        }
    }
}
