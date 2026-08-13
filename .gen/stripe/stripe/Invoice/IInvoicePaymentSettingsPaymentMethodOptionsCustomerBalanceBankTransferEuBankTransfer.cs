using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer
    {
        /// <summary>The desired country code of the bank account information. Permitted values include: `DE`, `FR`, `IE`, or `NL`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#country Invoice#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        string Country
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The desired country code of the bank account information. Permitted values include: `DE`, `FR`, `IE`, or `NL`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#country Invoice#country}
            /// </remarks>
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
            public string Country
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
