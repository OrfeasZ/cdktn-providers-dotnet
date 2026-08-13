using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataIdeal), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataIdeal")]
    public interface ISetupIntentPaymentMethodDataIdeal
    {
        /// <summary>The customer's bank. Only use this parameter for existing customers. Don't use it for new customers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bank SetupIntent#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bank
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataIdeal), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataIdeal")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank. Only use this parameter for existing customers. Don't use it for new customers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bank SetupIntent#bank}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bank
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
