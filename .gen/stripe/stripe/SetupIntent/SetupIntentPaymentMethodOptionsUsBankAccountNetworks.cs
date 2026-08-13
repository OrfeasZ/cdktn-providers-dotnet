using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworks")]
    public class SetupIntentPaymentMethodOptionsUsBankAccountNetworks : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks
    {
        /// <summary>Triggers validations to run across the selected networks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#requested SetupIntent#requested}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requested", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Requested
        {
            get;
            set;
        }
    }
}
