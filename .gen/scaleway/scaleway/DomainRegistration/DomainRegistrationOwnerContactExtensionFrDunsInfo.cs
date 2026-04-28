using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo")]
    public class DomainRegistrationOwnerContactExtensionFrDunsInfo : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo
    {
        /// <summary>DUNS ID associated with the domain owner (for French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#duns_id DomainRegistration#duns_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dunsId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DunsId
        {
            get;
            set;
        }

        /// <summary>Local identifier of the domain owner (for French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#local_id DomainRegistration#local_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalId
        {
            get;
            set;
        }
    }
}
