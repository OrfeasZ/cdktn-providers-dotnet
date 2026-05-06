using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileFooterText), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileFooterText")]
    public interface IIdentityDomainsSelfRegistrationProfileFooterText
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#locale IdentityDomainsSelfRegistrationProfile#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        string Locale
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#value IdentityDomainsSelfRegistrationProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#default IdentityDomainsSelfRegistrationProfile#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileFooterText), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileFooterText")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileFooterText
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#locale IdentityDomainsSelfRegistrationProfile#locale}.</summary>
            [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
            public string Locale
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#value IdentityDomainsSelfRegistrationProfile#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#default IdentityDomainsSelfRegistrationProfile#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Default
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
