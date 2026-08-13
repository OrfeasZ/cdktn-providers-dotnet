using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance")]
    public class SetupIntentMandateDataCustomerAcceptance : stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance
    {
        /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The time at which the customer accepted the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#accepted_at SetupIntent#accepted_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AcceptedAt
        {
            get;
            set;
        }

        /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#online SetupIntent#online}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline? Online
        {
            get;
            set;
        }
    }
}
