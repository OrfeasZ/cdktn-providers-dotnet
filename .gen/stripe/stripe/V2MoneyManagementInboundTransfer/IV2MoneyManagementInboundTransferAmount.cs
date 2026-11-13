using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementInboundTransfer
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementInboundTransferAmount), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferAmount")]
    public interface IV2MoneyManagementInboundTransferAmount
    {
        /// <summary>The currency of the monetary amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#currency V2MoneyManagementInboundTransfer#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The monetary amount in minor units of the currency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#value V2MoneyManagementInboundTransfer#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementInboundTransferAmount), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency of the monetary amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#currency V2MoneyManagementInboundTransfer#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The monetary amount in minor units of the currency.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#value V2MoneyManagementInboundTransfer#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
