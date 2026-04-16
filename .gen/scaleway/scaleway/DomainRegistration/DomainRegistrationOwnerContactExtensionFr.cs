using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr")]
    public class DomainRegistrationOwnerContactExtensionFr : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr
    {
        /// <summary>association_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#association_info DomainRegistration#association_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo? AssociationInfo
        {
            get;
            set;
        }

        /// <summary>code_auth_afnic_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#code_auth_afnic_info DomainRegistration#code_auth_afnic_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo? CodeAuthAfnicInfo
        {
            get;
            set;
        }

        /// <summary>duns_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#duns_info DomainRegistration#duns_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo? DunsInfo
        {
            get;
            set;
        }

        /// <summary>individual_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#individual_info DomainRegistration#individual_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo? IndividualInfo
        {
            get;
            set;
        }

        /// <summary>Mode of the French extension (e.g., 'individual', 'duns', 'association', etc.).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#mode DomainRegistration#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>trademark_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#trademark_info DomainRegistration#trademark_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo? TrademarkInfo
        {
            get;
            set;
        }
    }
}
