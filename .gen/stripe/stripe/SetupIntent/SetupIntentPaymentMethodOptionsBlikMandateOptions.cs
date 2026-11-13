using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBlikMandateOptions")]
    public class SetupIntentPaymentMethodOptionsBlikMandateOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBlikMandateOptions
    {
        /// <summary>Date at which the mandate expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/setup_intent#expires_at SetupIntent#expires_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAt
        {
            get;
            set;
        }
    }
}
