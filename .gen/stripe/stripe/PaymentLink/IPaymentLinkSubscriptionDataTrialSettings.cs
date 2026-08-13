using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkSubscriptionDataTrialSettings), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings")]
    public interface IPaymentLinkSubscriptionDataTrialSettings
    {
        /// <summary>Defines how a subscription behaves when a free trial ends.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#end_behavior PaymentLink#end_behavior}
        /// </remarks>
        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettingsEndBehavior\"}")]
        stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkSubscriptionDataTrialSettings), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines how a subscription behaves when a free trial ends.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#end_behavior PaymentLink#end_behavior}
            /// </remarks>
            [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettingsEndBehavior\"}")]
            public stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettingsEndBehavior>()!;
            }
        }
    }
}
