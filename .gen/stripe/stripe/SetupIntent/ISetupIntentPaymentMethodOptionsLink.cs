using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsLink), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsLink")]
    public interface ISetupIntentPaymentMethodOptionsLink
    {
        /// <summary>[Deprecated] This is a legacy parameter that no longer has any function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#persistent_token SetupIntent#persistent_token}
        /// </remarks>
        [JsiiProperty(name: "persistentToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistentToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsLink), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsLink")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>[Deprecated] This is a legacy parameter that no longer has any function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#persistent_token SetupIntent#persistent_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistentToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
