using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu")]
    public class DomainRegistrationOwnerContactExtensionEu : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu
    {
        /// <summary>Indicates the European citizenship of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#european_citizenship DomainRegistration#european_citizenship}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "europeanCitizenship", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EuropeanCitizenship
        {
            get;
            set;
        }
    }
}
