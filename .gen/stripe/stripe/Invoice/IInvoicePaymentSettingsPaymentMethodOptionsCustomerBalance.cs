using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#bank_transfer Invoice#bank_transfer}.</summary>
        [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer? BankTransfer
        {
            get
            {
                return null;
            }
        }

        /// <summary>The funding method type to be used when there are not enough funds in the customer balance.</summary>
        /// <remarks>
        /// Permitted values include: <c>bank_transfer</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#funding_type Invoice#funding_type}
        /// </remarks>
        [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FundingType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#bank_transfer Invoice#bank_transfer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer? BankTransfer
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer?>();
            }

            /// <summary>The funding method type to be used when there are not enough funds in the customer balance.</summary>
            /// <remarks>
            /// Permitted values include: <c>bank_transfer</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#funding_type Invoice#funding_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FundingType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
