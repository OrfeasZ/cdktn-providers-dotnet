using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBlik")]
    public class SetupIntentPaymentMethodOptionsBlik : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBlik
    {
        /// <summary>The 6-digit BLIK code that a customer has generated using their banking application. Can only be set on confirmation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/setup_intent#code SetupIntent#code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBlikMandateOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBlikMandateOptions? MandateOptions
        {
            get;
            set;
        }
    }
}
