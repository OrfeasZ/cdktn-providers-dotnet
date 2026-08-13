using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsLink")]
    public class SetupIntentPaymentMethodOptionsLink : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink
    {
        /// <summary>[Deprecated] This is a legacy parameter that no longer has any function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#persistent_token SetupIntent#persistent_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "persistentToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistentToken
        {
            get;
            set;
        }
    }
}
