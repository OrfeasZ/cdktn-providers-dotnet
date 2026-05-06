using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppConfig")]
    public class IdentityDomainsAppConfig : oci.IdentityDomainsApp.IIdentityDomainsAppConfig
    {
        /// <summary>based_on_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#based_on_template IdentityDomainsApp#based_on_template}
        /// </remarks>
        [JsiiProperty(name: "basedOnTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate\"}")]
        public oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate BasedOnTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#display_name IdentityDomainsApp#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idcs_endpoint IdentityDomainsApp#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#schemas IdentityDomainsApp#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Schemas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token_expiry IdentityDomainsApp#access_token_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AccessTokenExpiry
        {
            get;
            set;
        }

        private object? _active;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#active IdentityDomainsApp#active}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Active
        {
            get => _active;
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
                _active = value;
            }
        }

        private object? _aliasApps;

        /// <summary>alias_apps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#alias_apps IdentityDomainsApp#alias_apps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasApps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasApps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AliasApps
        {
            get => _aliasApps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppAliasApps[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAliasApps).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _aliasApps = value;
            }
        }

        private object? _allowAccessControl;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_access_control IdentityDomainsApp#allow_access_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAccessControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowAccessControl
        {
            get => _allowAccessControl;
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
                _allowAccessControl = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_grants IdentityDomainsApp#allowed_grants}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedGrants", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedGrants
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_operations IdentityDomainsApp#allowed_operations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedOperations
        {
            get;
            set;
        }

        private object? _allowedScopes;

        /// <summary>allowed_scopes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_scopes IdentityDomainsApp#allowed_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedScopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedScopes
        {
            get => _allowedScopes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppAllowedScopes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedScopes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedScopes = value;
            }
        }

        private object? _allowedTags;

        /// <summary>allowed_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_tags IdentityDomainsApp#allowed_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedTags
        {
            get => _allowedTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppAllowedTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedTags = value;
            }
        }

        private object? _allowOffline;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_offline IdentityDomainsApp#allow_offline}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowOffline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowOffline
        {
            get => _allowOffline;
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
                _allowOffline = value;
            }
        }

        private object? _allUrlSchemesAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#all_url_schemes_allowed IdentityDomainsApp#all_url_schemes_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allUrlSchemesAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllUrlSchemesAllowed
        {
            get => _allUrlSchemesAllowed;
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
                _allUrlSchemesAllowed = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_icon IdentityDomainsApp#app_icon}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppIcon
        {
            get;
            set;
        }

        /// <summary>app_signon_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_signon_policy IdentityDomainsApp#app_signon_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appSignonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy? AppSignonPolicy
        {
            get;
            set;
        }

        private object? _appsNetworkPerimeters;

        /// <summary>apps_network_perimeters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#apps_network_perimeters IdentityDomainsApp#apps_network_perimeters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appsNetworkPerimeters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppsNetworkPerimeters
        {
            get => _appsNetworkPerimeters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppAppsNetworkPerimeters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAppsNetworkPerimeters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _appsNetworkPerimeters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_thumbnail IdentityDomainsApp#app_thumbnail}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppThumbnail
        {
            get;
            set;
        }

        /// <summary>as_opc_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#as_opc_service IdentityDomainsApp#as_opc_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asOpcService", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcService\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService? AsOpcService
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attributes IdentityDomainsApp#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attribute_sets IdentityDomainsApp#attribute_sets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeSets
        {
            get;
            set;
        }

        private object? _attrRenderingMetadata;

        /// <summary>attr_rendering_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attr_rendering_metadata IdentityDomainsApp#attr_rendering_metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attrRenderingMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AttrRenderingMetadata
        {
            get => _attrRenderingMetadata;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppAttrRenderingMetadata[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAttrRenderingMetadata).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _attrRenderingMetadata = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#audience IdentityDomainsApp#audience}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#authorization IdentityDomainsApp#authorization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Authorization
        {
            get;
            set;
        }

        private object? _bypassConsent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#bypass_consent IdentityDomainsApp#bypass_consent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassConsent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BypassConsent
        {
            get => _bypassConsent;
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
                _bypassConsent = value;
            }
        }

        private object? _certificates;

        /// <summary>certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#certificates IdentityDomainsApp#certificates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Certificates
        {
            get => _certificates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppCertificates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppCertificates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certificates = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip_checking IdentityDomainsApp#client_ip_checking}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientIpChecking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientIpChecking
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_type IdentityDomainsApp#client_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#contact_email_address IdentityDomainsApp#contact_email_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contactEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContactEmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#delegated_service_names IdentityDomainsApp#delegated_service_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delegatedServiceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DelegatedServiceNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#description IdentityDomainsApp#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _disableKmsiTokenAuthentication;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#disable_kmsi_token_authentication IdentityDomainsApp#disable_kmsi_token_authentication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableKmsiTokenAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableKmsiTokenAuthentication
        {
            get => _disableKmsiTokenAuthentication;
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
                _disableKmsiTokenAuthentication = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#error_page_url IdentityDomainsApp#error_page_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorPageUrl
        {
            get;
            set;
        }

        private object? _forceDelete;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#force_delete IdentityDomainsApp#force_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ForceDelete
        {
            get => _forceDelete;
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
                _forceDelete = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#home_page_url IdentityDomainsApp#home_page_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homePageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomePageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#icon IdentityDomainsApp#icon}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Icon
        {
            get;
            set;
        }

        private object? _identityProviders;

        /// <summary>identity_providers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#identity_providers IdentityDomainsApp#identity_providers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityProviders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProviders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityProviders
        {
            get => _identityProviders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppIdentityProviders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppIdentityProviders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityProviders = value;
            }
        }

        /// <summary>idp_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idp_policy IdentityDomainsApp#idp_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idpPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy? IdpPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#id_token_enc_algo IdentityDomainsApp#id_token_enc_algo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idTokenEncAlgo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdTokenEncAlgo
        {
            get;
            set;
        }

        private object? _isAliasApp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_alias_app IdentityDomainsApp#is_alias_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAliasApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAliasApp
        {
            get => _isAliasApp;
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
                _isAliasApp = value;
            }
        }

        private object? _isEnterpriseApp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_enterprise_app IdentityDomainsApp#is_enterprise_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnterpriseApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnterpriseApp
        {
            get => _isEnterpriseApp;
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
                _isEnterpriseApp = value;
            }
        }

        private object? _isFormFill;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_form_fill IdentityDomainsApp#is_form_fill}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFormFill", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFormFill
        {
            get => _isFormFill;
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
                _isFormFill = value;
            }
        }

        private object? _isKerberosRealm;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_kerberos_realm IdentityDomainsApp#is_kerberos_realm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isKerberosRealm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsKerberosRealm
        {
            get => _isKerberosRealm;
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
                _isKerberosRealm = value;
            }
        }

        private object? _isLoginTarget;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_login_target IdentityDomainsApp#is_login_target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isLoginTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsLoginTarget
        {
            get => _isLoginTarget;
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
                _isLoginTarget = value;
            }
        }

        private object? _isMobileTarget;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_mobile_target IdentityDomainsApp#is_mobile_target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMobileTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMobileTarget
        {
            get => _isMobileTarget;
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
                _isMobileTarget = value;
            }
        }

        private object? _isMulticloudServiceApp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_multicloud_service_app IdentityDomainsApp#is_multicloud_service_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMulticloudServiceApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMulticloudServiceApp
        {
            get => _isMulticloudServiceApp;
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
                _isMulticloudServiceApp = value;
            }
        }

        private object? _isOauthClient;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_client IdentityDomainsApp#is_oauth_client}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOauthClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOauthClient
        {
            get => _isOauthClient;
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
                _isOauthClient = value;
            }
        }

        private object? _isOauthResource;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_resource IdentityDomainsApp#is_oauth_resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOauthResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOauthResource
        {
            get => _isOauthResource;
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
                _isOauthResource = value;
            }
        }

        private object? _isObligationCapable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_obligation_capable IdentityDomainsApp#is_obligation_capable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isObligationCapable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsObligationCapable
        {
            get => _isObligationCapable;
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
                _isObligationCapable = value;
            }
        }

        private object? _isRadiusApp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_radius_app IdentityDomainsApp#is_radius_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRadiusApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRadiusApp
        {
            get => _isRadiusApp;
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
                _isRadiusApp = value;
            }
        }

        private object? _isSamlServiceProvider;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_saml_service_provider IdentityDomainsApp#is_saml_service_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSamlServiceProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSamlServiceProvider
        {
            get => _isSamlServiceProvider;
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
                _isSamlServiceProvider = value;
            }
        }

        private object? _isUnmanagedApp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_unmanaged_app IdentityDomainsApp#is_unmanaged_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isUnmanagedApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsUnmanagedApp
        {
            get => _isUnmanagedApp;
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
                _isUnmanagedApp = value;
            }
        }

        private object? _isWebTierPolicy;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_web_tier_policy IdentityDomainsApp#is_web_tier_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isWebTierPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsWebTierPolicy
        {
            get => _isWebTierPolicy;
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
                _isWebTierPolicy = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#landing_page_url IdentityDomainsApp#landing_page_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "landingPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LandingPageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#linking_callback_url IdentityDomainsApp#linking_callback_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkingCallbackUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LinkingCallbackUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_mechanism IdentityDomainsApp#login_mechanism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoginMechanism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_page_url IdentityDomainsApp#login_page_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoginPageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_page_url IdentityDomainsApp#logout_page_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutPageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_uri IdentityDomainsApp#logout_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name IdentityDomainsApp#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ocid IdentityDomainsApp#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#post_logout_redirect_uris IdentityDomainsApp#post_logout_redirect_uris}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PostLogoutRedirectUris
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#privacy_policy_url IdentityDomainsApp#privacy_policy_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivacyPolicyUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_logo_url IdentityDomainsApp#product_logo_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "productLogoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductLogoUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_name IdentityDomainsApp#product_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductName
        {
            get;
            set;
        }

        private object? _protectableSecondaryAudiences;

        /// <summary>protectable_secondary_audiences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#protectable_secondary_audiences IdentityDomainsApp#protectable_secondary_audiences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protectableSecondaryAudiences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProtectableSecondaryAudiences
        {
            get => _protectableSecondaryAudiences;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppProtectableSecondaryAudiences[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppProtectableSecondaryAudiences).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _protectableSecondaryAudiences = value;
            }
        }

        /// <summary>radius_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_policy IdentityDomainsApp#radius_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radiusPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy? RadiusPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#redirect_uris IdentityDomainsApp#redirect_uris}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RedirectUris
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#refresh_token_expiry IdentityDomainsApp#refresh_token_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RefreshTokenExpiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_type_schema_version IdentityDomainsApp#resource_type_schema_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTypeSchemaVersion
        {
            get;
            set;
        }

        /// <summary>saml_service_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#saml_service_provider IdentityDomainsApp#saml_service_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "samlServiceProvider", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProvider\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider? SamlServiceProvider
        {
            get;
            set;
        }

        private object? _scopes;

        /// <summary>scopes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#scopes IdentityDomainsApp#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Scopes
        {
            get => _scopes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppScopes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppScopes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scopes = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secondary_audiences IdentityDomainsApp#secondary_audiences}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecondaryAudiences
        {
            get;
            set;
        }

        private object? _serviceParams;

        /// <summary>service_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_params IdentityDomainsApp#service_params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServiceParams
        {
            get => _serviceParams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppServiceParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppServiceParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceParams = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_urn IdentityDomainsApp#service_type_urn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceTypeUrn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_version IdentityDomainsApp#service_type_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceTypeVersion
        {
            get;
            set;
        }

        private object? _showInMyApps;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#show_in_my_apps IdentityDomainsApp#show_in_my_apps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "showInMyApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShowInMyApps
        {
            get => _showInMyApps;
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
                _showInMyApps = value;
            }
        }

        /// <summary>signon_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signon_policy IdentityDomainsApp#signon_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy? SignonPolicy
        {
            get;
            set;
        }

        private object? _tags;

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#tags IdentityDomainsApp#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tags
        {
            get => _tags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_service_url IdentityDomainsApp#terms_of_service_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TermsOfServiceUrl
        {
            get;
            set;
        }

        /// <summary>terms_of_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_use IdentityDomainsApp#terms_of_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfUse", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUse\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse? TermsOfUse
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#timeouts IdentityDomainsApp#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeouts\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _trustPolicies;

        /// <summary>trust_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_policies IdentityDomainsApp#trust_policies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustPolicies
        {
            get => _trustPolicies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppTrustPolicies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTrustPolicies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustPolicies = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_scope IdentityDomainsApp#trust_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustScope
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensiondbcs_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensiondbcs_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensiondbcs_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp? UrnietfparamsscimschemasoracleidcsextensiondbcsApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionenterprise_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp? UrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp? UrnietfparamsscimschemasoracleidcsextensionformFillAppApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate? UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp? UrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmanagedapp_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? UrnietfparamsscimschemasoracleidcsextensionmanagedappApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp? UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextension_oci_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionopc_service_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionopc_service_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionopc_service_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp? UrnietfparamsscimschemasoracleidcsextensionopcServiceApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionradius_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionradius_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionradius_app_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp? UrnietfparamsscimschemasoracleidcsextensionradiusAppApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionrequestable_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionrequestable_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionrequestable_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp? UrnietfparamsscimschemasoracleidcsextensionrequestableApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp? UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp? UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
