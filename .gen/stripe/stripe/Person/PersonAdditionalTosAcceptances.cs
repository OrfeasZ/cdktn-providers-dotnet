using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonAdditionalTosAcceptances")]
    public class PersonAdditionalTosAcceptances : stripe.Person.IPersonAdditionalTosAcceptances
    {
        /// <summary>Details on the legal guardian's acceptance of the main Stripe service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#account Person#account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptancesAccount\"}", isOptional: true)]
        public stripe.Person.IPersonAdditionalTosAcceptancesAccount? Account
        {
            get;
            set;
        }
    }
}
