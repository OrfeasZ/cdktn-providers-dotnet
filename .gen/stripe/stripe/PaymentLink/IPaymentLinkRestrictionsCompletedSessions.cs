using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkRestrictionsCompletedSessions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkRestrictionsCompletedSessions")]
    public interface IPaymentLinkRestrictionsCompletedSessions
    {
        /// <summary>The maximum number of checkout sessions that can be completed for the `completed_sessions` restriction to be met.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#limit PaymentLink#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkRestrictionsCompletedSessions), fullyQualifiedName: "stripe.paymentLink.PaymentLinkRestrictionsCompletedSessions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkRestrictionsCompletedSessions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of checkout sessions that can be completed for the `completed_sessions` restriction to be met.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#limit PaymentLink#limit}
            /// </remarks>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
