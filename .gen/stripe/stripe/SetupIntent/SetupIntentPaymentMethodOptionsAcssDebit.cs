using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebit")]
    public class SetupIntentPaymentMethodOptionsAcssDebit : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebit
    {
        /// <summary>Currency supported by the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebitMandateOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebitMandateOptions? MandateOptions
        {
            get;
            set;
        }

        /// <summary>Bank account verification method. The default value is `automatic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#verification_method SetupIntent#verification_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerificationMethod
        {
            get;
            set;
        }
    }
}
