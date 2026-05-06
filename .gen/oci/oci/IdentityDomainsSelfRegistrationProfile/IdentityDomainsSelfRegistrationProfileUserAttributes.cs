using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileUserAttributes")]
    public class IdentityDomainsSelfRegistrationProfileUserAttributes : oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileUserAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#seq_number IdentityDomainsSelfRegistrationProfile#seq_number}.</summary>
        [JsiiProperty(name: "seqNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double SeqNumber
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#fully_qualified_attribute_name IdentityDomainsSelfRegistrationProfile#fully_qualified_attribute_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fullyQualifiedAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FullyQualifiedAttributeName
        {
            get;
            set;
        }
    }
}
