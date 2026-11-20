using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionNl")]
    public class DomainRegistrationOwnerContactExtensionNl : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionNl
    {
        /// <summary>SIDN legal form for .nl domains (e.g. limited_company, natural_person). Distinct from the contact-level legal_form.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LegalForm
        {
            get;
            set;
        }

        /// <summary>KvK (Chamber of Commerce) or other registry registration number for the SIDN legal form.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form_registration_number DomainRegistration#legal_form_registration_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "legalFormRegistrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LegalFormRegistrationNumber
        {
            get;
            set;
        }
    }
}
