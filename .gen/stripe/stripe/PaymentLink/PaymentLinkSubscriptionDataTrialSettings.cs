using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings")]
    public class PaymentLinkSubscriptionDataTrialSettings : stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings
    {
        /// <summary>Defines how a subscription behaves when a free trial ends.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#end_behavior PaymentLink#end_behavior}
        /// </remarks>
        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettingsEndBehavior\"}")]
        public stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior
        {
            get;
            set;
        }
    }
}
