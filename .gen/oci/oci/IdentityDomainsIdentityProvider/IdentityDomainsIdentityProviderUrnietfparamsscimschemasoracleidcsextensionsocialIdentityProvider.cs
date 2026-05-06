using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider")]
    public class IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider : oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
    {
        private object _accountLinkingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#account_linking_enabled IdentityDomainsIdentityProvider#account_linking_enabled}.</summary>
        [JsiiProperty(name: "accountLinkingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object AccountLinkingEnabled
        {
            get => _accountLinkingEnabled;
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
                _accountLinkingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#consumer_key IdentityDomainsIdentityProvider#consumer_key}.</summary>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#consumer_secret IdentityDomainsIdentityProvider#consumer_secret}.</summary>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerSecret
        {
            get;
            set;
        }

        private object _registrationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#registration_enabled IdentityDomainsIdentityProvider#registration_enabled}.</summary>
        [JsiiProperty(name: "registrationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object RegistrationEnabled
        {
            get => _registrationEnabled;
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
                _registrationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#service_provider_name IdentityDomainsIdentityProvider#service_provider_name}.</summary>
        [JsiiProperty(name: "serviceProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceProviderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#access_token_url IdentityDomainsIdentityProvider#access_token_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessTokenUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#admin_scope IdentityDomainsIdentityProvider#admin_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdminScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#authz_url IdentityDomainsIdentityProvider#authz_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authzUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthzUrl
        {
            get;
            set;
        }

        private object? _autoRedirectEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#auto_redirect_enabled IdentityDomainsIdentityProvider#auto_redirect_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRedirectEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoRedirectEnabled
        {
            get => _autoRedirectEnabled;
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
                _autoRedirectEnabled = value;
            }
        }

        private object? _clientCredentialInPayload;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#client_credential_in_payload IdentityDomainsIdentityProvider#client_credential_in_payload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCredentialInPayload", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ClientCredentialInPayload
        {
            get => _clientCredentialInPayload;
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
                _clientCredentialInPayload = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#clock_skew_in_seconds IdentityDomainsIdentityProvider#clock_skew_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clockSkewInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClockSkewInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#discovery_url IdentityDomainsIdentityProvider#discovery_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiscoveryUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#id_attribute IdentityDomainsIdentityProvider#id_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdAttribute
        {
            get;
            set;
        }

        private object? _jitProvAssignedGroups;

        /// <summary>jit_prov_assigned_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_prov_assigned_groups IdentityDomainsIdentityProvider#jit_prov_assigned_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jitProvAssignedGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JitProvAssignedGroups
        {
            get => _jitProvAssignedGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jitProvAssignedGroups = value;
            }
        }

        private object? _jitProvGroupStaticListEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_prov_group_static_list_enabled IdentityDomainsIdentityProvider#jit_prov_group_static_list_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jitProvGroupStaticListEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? JitProvGroupStaticListEnabled
        {
            get => _jitProvGroupStaticListEnabled;
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
                _jitProvGroupStaticListEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#profile_url IdentityDomainsIdentityProvider#profile_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#redirect_url IdentityDomainsIdentityProvider#redirect_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#scope IdentityDomainsIdentityProvider#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scope
        {
            get;
            set;
        }

        private object? _socialJitProvisioningEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#social_jit_provisioning_enabled IdentityDomainsIdentityProvider#social_jit_provisioning_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "socialJitProvisioningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SocialJitProvisioningEnabled
        {
            get => _socialJitProvisioningEnabled;
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
                _socialJitProvisioningEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#status IdentityDomainsIdentityProvider#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
