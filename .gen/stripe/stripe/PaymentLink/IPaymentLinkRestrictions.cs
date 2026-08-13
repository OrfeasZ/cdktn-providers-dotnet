using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkRestrictions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkRestrictions")]
    public interface IPaymentLinkRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#completed_sessions PaymentLink#completed_sessions}.</summary>
        [JsiiProperty(name: "completedSessions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictionsCompletedSessions\"}")]
        stripe.PaymentLink.IPaymentLinkRestrictionsCompletedSessions CompletedSessions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkRestrictions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkRestrictions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#completed_sessions PaymentLink#completed_sessions}.</summary>
            [JsiiProperty(name: "completedSessions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictionsCompletedSessions\"}")]
            public stripe.PaymentLink.IPaymentLinkRestrictionsCompletedSessions CompletedSessions
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkRestrictionsCompletedSessions>()!;
            }
        }
    }
}
