using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsSepaDebit")]
    public class SetupIntentPaymentMethodOptionsSepaDebit : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsSepaDebitMandateOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebitMandateOptions? MandateOptions
        {
            get;
            set;
        }
    }
}
