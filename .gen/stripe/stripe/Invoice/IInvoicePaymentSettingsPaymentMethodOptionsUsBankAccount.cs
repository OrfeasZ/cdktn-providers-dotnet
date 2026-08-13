using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount")]
    public interface IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#financial_connections Invoice#financial_connections}.</summary>
        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Bank account verification method. The default value is `automatic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#verification_method Invoice#verification_method}
        /// </remarks>
        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerificationMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#financial_connections Invoice#financial_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections?>();
            }

            /// <summary>Bank account verification method. The default value is `automatic`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#verification_method Invoice#verification_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerificationMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
