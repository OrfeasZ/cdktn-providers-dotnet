using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementInboundTransfer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferFrom")]
    public class V2MoneyManagementInboundTransferFrom : stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferFrom
    {
        /// <summary>The bank account credential used to fund the InboundTransfer (for example, a US bank account), not a Payments API `pm_` PaymentMethod.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#payment_method V2MoneyManagementInboundTransfer#payment_method}
        /// </remarks>
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferFromPaymentMethod\"}")]
        public stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferFromPaymentMethod PaymentMethod
        {
            get;
            set;
        }

        /// <summary>An optional currency field used to specify which currency is debited from the Payment Method.</summary>
        /// <remarks>
        /// Since many Payment Methods support only one currency, this field is optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#currency V2MoneyManagementInboundTransfer#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }
    }
}
