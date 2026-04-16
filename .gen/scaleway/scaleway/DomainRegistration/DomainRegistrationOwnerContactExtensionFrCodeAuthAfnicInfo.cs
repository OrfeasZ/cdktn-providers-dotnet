using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo")]
    public class DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo
    {
        /// <summary>AFNIC authorization code for the contact (specific to French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#code_auth_afnic DomainRegistration#code_auth_afnic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeAuthAfnic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CodeAuthAfnic
        {
            get;
            set;
        }
    }
}
