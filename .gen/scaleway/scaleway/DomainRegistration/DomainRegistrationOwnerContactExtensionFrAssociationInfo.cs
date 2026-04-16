using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo")]
    public class DomainRegistrationOwnerContactExtensionFrAssociationInfo : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo
    {
        /// <summary>Publication date in the Official Journal (RFC3339 format) for association information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo DomainRegistration#publication_jo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicationJo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicationJo
        {
            get;
            set;
        }

        /// <summary>Page number of the publication in the Official Journal for association information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo_page DomainRegistration#publication_jo_page}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicationJoPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PublicationJoPage
        {
            get;
            set;
        }
    }
}
