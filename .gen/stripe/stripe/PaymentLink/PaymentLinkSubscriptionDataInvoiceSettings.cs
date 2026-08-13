using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings")]
    public class PaymentLinkSubscriptionDataInvoiceSettings : stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#issuer PaymentLink#issuer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettingsIssuer\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettingsIssuer? Issuer
        {
            get;
            set;
        }
    }
}
