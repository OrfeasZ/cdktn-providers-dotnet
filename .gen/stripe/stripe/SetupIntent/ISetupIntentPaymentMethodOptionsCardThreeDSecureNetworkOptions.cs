using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
    public interface ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
    {
        /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cartes_bancaires SetupIntent#cartes_bancaires}
        /// </remarks>
        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cartes_bancaires SetupIntent#cartes_bancaires}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires?>();
            }
        }
    }
}
