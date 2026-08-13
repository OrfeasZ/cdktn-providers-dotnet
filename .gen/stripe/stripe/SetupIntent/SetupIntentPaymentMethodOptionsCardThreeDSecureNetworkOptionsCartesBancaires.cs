using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires")]
    public class SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires
    {
        /// <summary>The cryptogram calculation algorithm used by the card Issuer's ACS to calculate the Authentication cryptogram. Also known as `cavvAlgorithm`. messageExtension: CB-AVALGO.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cb_avalgo SetupIntent#cb_avalgo}
        /// </remarks>
        [JsiiProperty(name: "cbAvalgo", typeJson: "{\"primitive\":\"string\"}")]
        public string CbAvalgo
        {
            get;
            set;
        }

        /// <summary>The exemption indicator returned from Cartes Bancaires in the ARes.</summary>
        /// <remarks>
        /// message extension: CB-EXEMPTION; string (4 characters)
        /// This is a 3 byte bitmap (low significant byte first and most significant
        /// bit first) that has been Base64 encoded
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cb_exemption SetupIntent#cb_exemption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cbExemption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CbExemption
        {
            get;
            set;
        }

        /// <summary>The risk score returned from Cartes Bancaires in the ARes. message extension: CB-SCORE; numeric value 0-99.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#cb_score SetupIntent#cb_score}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cbScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CbScore
        {
            get;
            set;
        }
    }
}
