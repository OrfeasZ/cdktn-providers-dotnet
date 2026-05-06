using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser
    {
        private object? _bypassCodes;

        /// <summary>bypass_codes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_codes IdentityDomainsUser#bypass_codes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bypassCodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BypassCodes
        {
            get => _bypassCodes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bypassCodes = value;
            }
        }

        private object? _devices;

        /// <summary>devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#devices IdentityDomainsUser#devices}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Devices
        {
            get => _devices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _devices = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#login_attempts IdentityDomainsUser#login_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoginAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_enabled_on IdentityDomainsUser#mfa_enabled_on}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaEnabledOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MfaEnabledOn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_ignored_apps IdentityDomainsUser#mfa_ignored_apps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaIgnoredApps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MfaIgnoredApps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_status IdentityDomainsUser#mfa_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MfaStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_factor IdentityDomainsUser#preferred_authentication_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredAuthenticationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredAuthenticationFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_method IdentityDomainsUser#preferred_authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredAuthenticationMethod
        {
            get;
            set;
        }

        /// <summary>preferred_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_device IdentityDomainsUser#preferred_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredDevice", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice? PreferredDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_third_party_vendor IdentityDomainsUser#preferred_third_party_vendor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredThirdPartyVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredThirdPartyVendor
        {
            get;
            set;
        }

        private object? _trustedUserAgents;

        /// <summary>trusted_user_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#trusted_user_agents IdentityDomainsUser#trusted_user_agents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedUserAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustedUserAgents
        {
            get => _trustedUserAgents;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgents[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgents).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustedUserAgents = value;
            }
        }
    }
}
