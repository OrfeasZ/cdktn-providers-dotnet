using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentMandateData")]
    public class SetupIntentMandateData : stripe.SetupIntent.ISetupIntentMandateData
    {
        /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#customer_acceptance SetupIntent#customer_acceptance}
        /// </remarks>
        [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance\"}")]
        public stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance CustomerAcceptance
        {
            get;
            set;
        }
    }
}
