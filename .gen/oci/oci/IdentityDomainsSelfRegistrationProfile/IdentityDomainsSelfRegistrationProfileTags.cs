using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileTags")]
    public class IdentityDomainsSelfRegistrationProfileTags : oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#key IdentityDomainsSelfRegistrationProfile#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#value IdentityDomainsSelfRegistrationProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
