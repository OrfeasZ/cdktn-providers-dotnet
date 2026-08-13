using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataKlarna")]
    public class SetupIntentPaymentMethodDataKlarna : stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna
    {
        /// <summary>Customer's date of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#dob SetupIntent#dob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob? Dob
        {
            get;
            set;
        }
    }
}
