using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer")]
    public interface IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer
    {
        /// <summary>The bank transfer type that this PaymentIntent is allowed to use for funding Permitted values include: `eu_bank_transfer`, `gb_bank_transfer`, `jp_bank_transfer`, `mx_bank_transfer`, or `us_bank_transfer`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#eu_bank_transfer PaymentIntent#eu_bank_transfer}.</summary>
        [JsiiProperty(name: "euBankTransfer", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer? EuBankTransfer
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of address types that should be returned in the financial_addresses response.</summary>
        /// <remarks>
        /// If not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>sort_code</c>, <c>zengin</c>, <c>iban</c>, or <c>spei</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested_address_types PaymentIntent#requested_address_types}
        /// </remarks>
        [JsiiProperty(name: "requestedAddressTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RequestedAddressTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The bank transfer type that this PaymentIntent is allowed to use for funding Permitted values include: `eu_bank_transfer`, `gb_bank_transfer`, `jp_bank_transfer`, `mx_bank_transfer`, or `us_bank_transfer`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#eu_bank_transfer PaymentIntent#eu_bank_transfer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "euBankTransfer", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer? EuBankTransfer
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer?>();
            }

            /// <summary>List of address types that should be returned in the financial_addresses response.</summary>
            /// <remarks>
            /// If not specified, all valid types will be returned.
            ///
            /// Permitted values include: <c>sort_code</c>, <c>zengin</c>, <c>iban</c>, or <c>spei</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested_address_types PaymentIntent#requested_address_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestedAddressTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RequestedAddressTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
