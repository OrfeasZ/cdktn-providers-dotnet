using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings")]
    public class IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings : oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#attestation IdentityDomainsAuthenticationFactorSetting#attestation}.</summary>
        [JsiiProperty(name: "attestation", typeJson: "{\"primitive\":\"string\"}")]
        public string Attestation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#authenticator_selection_attachment IdentityDomainsAuthenticationFactorSetting#authenticator_selection_attachment}.</summary>
        [JsiiProperty(name: "authenticatorSelectionAttachment", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticatorSelectionAttachment
        {
            get;
            set;
        }

        private object _authenticatorSelectionRequireResidentKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#authenticator_selection_require_resident_key IdentityDomainsAuthenticationFactorSetting#authenticator_selection_require_resident_key}.</summary>
        [JsiiProperty(name: "authenticatorSelectionRequireResidentKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object AuthenticatorSelectionRequireResidentKey
        {
            get => _authenticatorSelectionRequireResidentKey;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticatorSelectionRequireResidentKey = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#authenticator_selection_resident_key IdentityDomainsAuthenticationFactorSetting#authenticator_selection_resident_key}.</summary>
        [JsiiProperty(name: "authenticatorSelectionResidentKey", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticatorSelectionResidentKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#authenticator_selection_user_verification IdentityDomainsAuthenticationFactorSetting#authenticator_selection_user_verification}.</summary>
        [JsiiProperty(name: "authenticatorSelectionUserVerification", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticatorSelectionUserVerification
        {
            get;
            set;
        }

        private object _excludeCredentials;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#exclude_credentials IdentityDomainsAuthenticationFactorSetting#exclude_credentials}.</summary>
        [JsiiProperty(name: "excludeCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object ExcludeCredentials
        {
            get => _excludeCredentials;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeCredentials = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#public_key_types IdentityDomainsAuthenticationFactorSetting#public_key_types}.</summary>
        [JsiiProperty(name: "publicKeyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PublicKeyTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#timeout IdentityDomainsAuthenticationFactorSetting#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public double Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#domain_validation_level IdentityDomainsAuthenticationFactorSetting#domain_validation_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainValidationLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DomainValidationLevel
        {
            get;
            set;
        }
    }
}
