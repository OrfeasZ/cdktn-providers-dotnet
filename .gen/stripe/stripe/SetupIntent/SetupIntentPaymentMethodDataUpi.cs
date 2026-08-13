using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataUpi")]
    public class SetupIntentPaymentMethodDataUpi : stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi
    {
        /// <summary>Configuration options for setting up an eMandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpiMandateOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataUpiMandateOptions? MandateOptions
        {
            get;
            set;
        }
    }
}
