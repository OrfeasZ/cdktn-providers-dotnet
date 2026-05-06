using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileDisplayName")]
    public class IdentityDomainsSelfRegistrationProfileDisplayName : oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileDisplayName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#locale IdentityDomainsSelfRegistrationProfile#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public string Locale
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

        private object? _default;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#default IdentityDomainsSelfRegistrationProfile#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Default
        {
            get => _default;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _default = value;
            }
        }
    }
}
