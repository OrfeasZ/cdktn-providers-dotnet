using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileUserAttributes), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileUserAttributes")]
    public interface IIdentityDomainsSelfRegistrationProfileUserAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#seq_number IdentityDomainsSelfRegistrationProfile#seq_number}.</summary>
        [JsiiProperty(name: "seqNumber", typeJson: "{\"primitive\":\"number\"}")]
        double SeqNumber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#value IdentityDomainsSelfRegistrationProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#fully_qualified_attribute_name IdentityDomainsSelfRegistrationProfile#fully_qualified_attribute_name}.</summary>
        [JsiiProperty(name: "fullyQualifiedAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FullyQualifiedAttributeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileUserAttributes), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileUserAttributes")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileUserAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#seq_number IdentityDomainsSelfRegistrationProfile#seq_number}.</summary>
            [JsiiProperty(name: "seqNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double SeqNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#value IdentityDomainsSelfRegistrationProfile#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#fully_qualified_attribute_name IdentityDomainsSelfRegistrationProfile#fully_qualified_attribute_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fullyQualifiedAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FullyQualifiedAttributeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
