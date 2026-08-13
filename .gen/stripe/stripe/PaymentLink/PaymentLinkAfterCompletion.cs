using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkAfterCompletion")]
    public class PaymentLinkAfterCompletion : stripe.PaymentLink.IPaymentLinkAfterCompletion
    {
        /// <summary>The specified behavior after the purchase is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#hosted_confirmation PaymentLink#hosted_confirmation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostedConfirmation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation? HostedConfirmation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#redirect PaymentLink#redirect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirect\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect? Redirect
        {
            get;
            set;
        }
    }
}
