using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebitMandateOptions")]
    public class SetupIntentPaymentMethodOptionsBacsDebitMandateOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebitMandateOptions
    {
        /// <summary>Prefix used to generate the Mandate reference.</summary>
        /// <remarks>
        /// Must be at most 12 characters long. Must consist of only uppercase letters, numbers, spaces, or the following special characters: '/', '_', '-', '&amp;', '.'. Cannot begin with 'DDIC' or 'STRIPE'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#reference_prefix SetupIntent#reference_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referencePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferencePrefix
        {
            get;
            set;
        }
    }
}
