using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsBlikMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBlikMandateOptions")]
    public interface ISetupIntentPaymentMethodOptionsBlikMandateOptions
    {
        /// <summary>Date at which the mandate expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/setup_intent#expires_at SetupIntent#expires_at}
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsBlikMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBlikMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBlikMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Date at which the mandate expires.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/setup_intent#expires_at SetupIntent#expires_at}
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
