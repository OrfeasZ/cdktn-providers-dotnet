using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettingsIssuer")]
    public class PaymentLinkSubscriptionDataInvoiceSettingsIssuer : stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettingsIssuer
    {
        /// <summary>Type of the account referenced.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The connected account being referenced when `type` is `account`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#account PaymentLink#account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Account
        {
            get;
            set;
        }
    }
}
