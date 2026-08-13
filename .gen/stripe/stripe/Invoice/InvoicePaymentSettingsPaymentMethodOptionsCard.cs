using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCard")]
    public class InvoicePaymentSettingsPaymentMethodOptionsCard : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#installments Invoice#installments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "installments", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCardInstallments\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCardInstallments? Installments
        {
            get;
            set;
        }

        /// <summary>We strongly recommend that you rely on our SCA Engine to automatically prompt your customers for authentication based on risk level and [other requirements](https://docs.stripe.com/strong-customer-authentication). However, if you wish to request 3D Secure based on logic from your own fraud engine, provide this option. Read our guide on [manually requesting 3D Secure](https://docs.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds) for more information on how this configuration interacts with Radar and our SCA Engine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#request_three_d_secure Invoice#request_three_d_secure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestThreeDSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestThreeDSecure
        {
            get;
            set;
        }
    }
}
