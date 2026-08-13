using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkRestrictions")]
    public class PaymentLinkRestrictions : stripe.PaymentLink.IPaymentLinkRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#completed_sessions PaymentLink#completed_sessions}.</summary>
        [JsiiProperty(name: "completedSessions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictionsCompletedSessions\"}")]
        public stripe.PaymentLink.IPaymentLinkRestrictionsCompletedSessions CompletedSessions
        {
            get;
            set;
        }
    }
}
