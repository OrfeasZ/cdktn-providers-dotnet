using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions
    {
        /// <summary>Date when the mandate expires and no further payments will be charged.</summary>
        /// <remarks>
        /// If not provided, the mandate will be set to be indefinite.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#expires_at Subscription#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Date when the mandate expires and no further payments will be charged.</summary>
            /// <remarks>
            /// If not provided, the mandate will be set to be indefinite.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#expires_at Subscription#expires_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAt
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
