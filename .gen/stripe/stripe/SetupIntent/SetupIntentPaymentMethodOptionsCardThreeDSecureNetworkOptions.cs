using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
    public class SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
    {
        /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cartes_bancaires SetupIntent#cartes_bancaires}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
        {
            get;
            set;
        }
    }
}
