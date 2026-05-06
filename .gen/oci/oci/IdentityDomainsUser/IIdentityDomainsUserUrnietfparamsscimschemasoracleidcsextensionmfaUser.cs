using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser
    {
        /// <summary>bypass_codes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_codes IdentityDomainsUser#bypass_codes}
        /// </remarks>
        [JsiiProperty(name: "bypassCodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BypassCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#devices IdentityDomainsUser#devices}
        /// </remarks>
        [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Devices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#login_attempts IdentityDomainsUser#login_attempts}.</summary>
        [JsiiProperty(name: "loginAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoginAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_enabled_on IdentityDomainsUser#mfa_enabled_on}.</summary>
        [JsiiProperty(name: "mfaEnabledOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaEnabledOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_ignored_apps IdentityDomainsUser#mfa_ignored_apps}.</summary>
        [JsiiProperty(name: "mfaIgnoredApps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MfaIgnoredApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_status IdentityDomainsUser#mfa_status}.</summary>
        [JsiiProperty(name: "mfaStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_factor IdentityDomainsUser#preferred_authentication_factor}.</summary>
        [JsiiProperty(name: "preferredAuthenticationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredAuthenticationFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_method IdentityDomainsUser#preferred_authentication_method}.</summary>
        [JsiiProperty(name: "preferredAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredAuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>preferred_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_device IdentityDomainsUser#preferred_device}
        /// </remarks>
        [JsiiProperty(name: "preferredDevice", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice? PreferredDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_third_party_vendor IdentityDomainsUser#preferred_third_party_vendor}.</summary>
        [JsiiProperty(name: "preferredThirdPartyVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredThirdPartyVendor
        {
            get
            {
                return null;
            }
        }

        /// <summary>trusted_user_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#trusted_user_agents IdentityDomainsUser#trusted_user_agents}
        /// </remarks>
        [JsiiProperty(name: "trustedUserAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrustedUserAgents
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bypass_codes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_codes IdentityDomainsUser#bypass_codes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bypassCodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BypassCodes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>devices block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#devices IdentityDomainsUser#devices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Devices
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#login_attempts IdentityDomainsUser#login_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoginAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_enabled_on IdentityDomainsUser#mfa_enabled_on}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaEnabledOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaEnabledOn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_ignored_apps IdentityDomainsUser#mfa_ignored_apps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaIgnoredApps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MfaIgnoredApps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#mfa_status IdentityDomainsUser#mfa_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_factor IdentityDomainsUser#preferred_authentication_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredAuthenticationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredAuthenticationFactor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_authentication_method IdentityDomainsUser#preferred_authentication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredAuthenticationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>preferred_device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_device IdentityDomainsUser#preferred_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredDevice", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice? PreferredDevice
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDevice?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_third_party_vendor IdentityDomainsUser#preferred_third_party_vendor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredThirdPartyVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredThirdPartyVendor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trusted_user_agents block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#trusted_user_agents IdentityDomainsUser#trusted_user_agents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustedUserAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrustedUserAgents
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
