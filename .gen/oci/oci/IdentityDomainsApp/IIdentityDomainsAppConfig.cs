using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppConfig), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppConfig")]
    public interface IIdentityDomainsAppConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>based_on_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#based_on_template IdentityDomainsApp#based_on_template}
        /// </remarks>
        [JsiiProperty(name: "basedOnTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate\"}")]
        oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate BasedOnTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#display_name IdentityDomainsApp#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idcs_endpoint IdentityDomainsApp#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#schemas IdentityDomainsApp#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token_expiry IdentityDomainsApp#access_token_expiry}.</summary>
        [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccessTokenExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#active IdentityDomainsApp#active}.</summary>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>alias_apps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#alias_apps IdentityDomainsApp#alias_apps}
        /// </remarks>
        [JsiiProperty(name: "aliasApps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasApps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AliasApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_access_control IdentityDomainsApp#allow_access_control}.</summary>
        [JsiiProperty(name: "allowAccessControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAccessControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_grants IdentityDomainsApp#allowed_grants}.</summary>
        [JsiiProperty(name: "allowedGrants", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedGrants
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_operations IdentityDomainsApp#allowed_operations}.</summary>
        [JsiiProperty(name: "allowedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowed_scopes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_scopes IdentityDomainsApp#allowed_scopes}
        /// </remarks>
        [JsiiProperty(name: "allowedScopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowed_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_tags IdentityDomainsApp#allowed_tags}
        /// </remarks>
        [JsiiProperty(name: "allowedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_offline IdentityDomainsApp#allow_offline}.</summary>
        [JsiiProperty(name: "allowOffline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowOffline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#all_url_schemes_allowed IdentityDomainsApp#all_url_schemes_allowed}.</summary>
        [JsiiProperty(name: "allUrlSchemesAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllUrlSchemesAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_icon IdentityDomainsApp#app_icon}.</summary>
        [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppIcon
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_signon_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_signon_policy IdentityDomainsApp#app_signon_policy}
        /// </remarks>
        [JsiiProperty(name: "appSignonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy? AppSignonPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>apps_network_perimeters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#apps_network_perimeters IdentityDomainsApp#apps_network_perimeters}
        /// </remarks>
        [JsiiProperty(name: "appsNetworkPerimeters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppsNetworkPerimeters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_thumbnail IdentityDomainsApp#app_thumbnail}.</summary>
        [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppThumbnail
        {
            get
            {
                return null;
            }
        }

        /// <summary>as_opc_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#as_opc_service IdentityDomainsApp#as_opc_service}
        /// </remarks>
        [JsiiProperty(name: "asOpcService", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService? AsOpcService
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attributes IdentityDomainsApp#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attribute_sets IdentityDomainsApp#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>attr_rendering_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attr_rendering_metadata IdentityDomainsApp#attr_rendering_metadata}
        /// </remarks>
        [JsiiProperty(name: "attrRenderingMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AttrRenderingMetadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#audience IdentityDomainsApp#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#authorization IdentityDomainsApp#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#bypass_consent IdentityDomainsApp#bypass_consent}.</summary>
        [JsiiProperty(name: "bypassConsent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BypassConsent
        {
            get
            {
                return null;
            }
        }

        /// <summary>certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#certificates IdentityDomainsApp#certificates}
        /// </remarks>
        [JsiiProperty(name: "certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Certificates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip_checking IdentityDomainsApp#client_ip_checking}.</summary>
        [JsiiProperty(name: "clientIpChecking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientIpChecking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_type IdentityDomainsApp#client_type}.</summary>
        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#contact_email_address IdentityDomainsApp#contact_email_address}.</summary>
        [JsiiProperty(name: "contactEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContactEmailAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#delegated_service_names IdentityDomainsApp#delegated_service_names}.</summary>
        [JsiiProperty(name: "delegatedServiceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DelegatedServiceNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#description IdentityDomainsApp#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#disable_kmsi_token_authentication IdentityDomainsApp#disable_kmsi_token_authentication}.</summary>
        [JsiiProperty(name: "disableKmsiTokenAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableKmsiTokenAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#error_page_url IdentityDomainsApp#error_page_url}.</summary>
        [JsiiProperty(name: "errorPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorPageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#force_delete IdentityDomainsApp#force_delete}.</summary>
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#home_page_url IdentityDomainsApp#home_page_url}.</summary>
        [JsiiProperty(name: "homePageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HomePageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#icon IdentityDomainsApp#icon}.</summary>
        [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Icon
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_providers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#identity_providers IdentityDomainsApp#identity_providers}
        /// </remarks>
        [JsiiProperty(name: "identityProviders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProviders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityProviders
        {
            get
            {
                return null;
            }
        }

        /// <summary>idp_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idp_policy IdentityDomainsApp#idp_policy}
        /// </remarks>
        [JsiiProperty(name: "idpPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy? IdpPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#id_token_enc_algo IdentityDomainsApp#id_token_enc_algo}.</summary>
        [JsiiProperty(name: "idTokenEncAlgo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdTokenEncAlgo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_alias_app IdentityDomainsApp#is_alias_app}.</summary>
        [JsiiProperty(name: "isAliasApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAliasApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_enterprise_app IdentityDomainsApp#is_enterprise_app}.</summary>
        [JsiiProperty(name: "isEnterpriseApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnterpriseApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_form_fill IdentityDomainsApp#is_form_fill}.</summary>
        [JsiiProperty(name: "isFormFill", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFormFill
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_kerberos_realm IdentityDomainsApp#is_kerberos_realm}.</summary>
        [JsiiProperty(name: "isKerberosRealm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsKerberosRealm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_login_target IdentityDomainsApp#is_login_target}.</summary>
        [JsiiProperty(name: "isLoginTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLoginTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_mobile_target IdentityDomainsApp#is_mobile_target}.</summary>
        [JsiiProperty(name: "isMobileTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMobileTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_multicloud_service_app IdentityDomainsApp#is_multicloud_service_app}.</summary>
        [JsiiProperty(name: "isMulticloudServiceApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMulticloudServiceApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_client IdentityDomainsApp#is_oauth_client}.</summary>
        [JsiiProperty(name: "isOauthClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsOauthClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_resource IdentityDomainsApp#is_oauth_resource}.</summary>
        [JsiiProperty(name: "isOauthResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsOauthResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_obligation_capable IdentityDomainsApp#is_obligation_capable}.</summary>
        [JsiiProperty(name: "isObligationCapable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsObligationCapable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_radius_app IdentityDomainsApp#is_radius_app}.</summary>
        [JsiiProperty(name: "isRadiusApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRadiusApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_saml_service_provider IdentityDomainsApp#is_saml_service_provider}.</summary>
        [JsiiProperty(name: "isSamlServiceProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSamlServiceProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_unmanaged_app IdentityDomainsApp#is_unmanaged_app}.</summary>
        [JsiiProperty(name: "isUnmanagedApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUnmanagedApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_web_tier_policy IdentityDomainsApp#is_web_tier_policy}.</summary>
        [JsiiProperty(name: "isWebTierPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsWebTierPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#landing_page_url IdentityDomainsApp#landing_page_url}.</summary>
        [JsiiProperty(name: "landingPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LandingPageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#linking_callback_url IdentityDomainsApp#linking_callback_url}.</summary>
        [JsiiProperty(name: "linkingCallbackUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LinkingCallbackUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_mechanism IdentityDomainsApp#login_mechanism}.</summary>
        [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoginMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_page_url IdentityDomainsApp#login_page_url}.</summary>
        [JsiiProperty(name: "loginPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoginPageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_page_url IdentityDomainsApp#logout_page_url}.</summary>
        [JsiiProperty(name: "logoutPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutPageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_uri IdentityDomainsApp#logout_uri}.</summary>
        [JsiiProperty(name: "logoutUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name IdentityDomainsApp#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ocid IdentityDomainsApp#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#post_logout_redirect_uris IdentityDomainsApp#post_logout_redirect_uris}.</summary>
        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PostLogoutRedirectUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#privacy_policy_url IdentityDomainsApp#privacy_policy_url}.</summary>
        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivacyPolicyUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_logo_url IdentityDomainsApp#product_logo_url}.</summary>
        [JsiiProperty(name: "productLogoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductLogoUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_name IdentityDomainsApp#product_name}.</summary>
        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductName
        {
            get
            {
                return null;
            }
        }

        /// <summary>protectable_secondary_audiences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#protectable_secondary_audiences IdentityDomainsApp#protectable_secondary_audiences}
        /// </remarks>
        [JsiiProperty(name: "protectableSecondaryAudiences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProtectableSecondaryAudiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>radius_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_policy IdentityDomainsApp#radius_policy}
        /// </remarks>
        [JsiiProperty(name: "radiusPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy? RadiusPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#redirect_uris IdentityDomainsApp#redirect_uris}.</summary>
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RedirectUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#refresh_token_expiry IdentityDomainsApp#refresh_token_expiry}.</summary>
        [JsiiProperty(name: "refreshTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RefreshTokenExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_type_schema_version IdentityDomainsApp#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>saml_service_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#saml_service_provider IdentityDomainsApp#saml_service_provider}
        /// </remarks>
        [JsiiProperty(name: "samlServiceProvider", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider? SamlServiceProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>scopes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#scopes IdentityDomainsApp#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Scopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secondary_audiences IdentityDomainsApp#secondary_audiences}.</summary>
        [JsiiProperty(name: "secondaryAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecondaryAudiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_params IdentityDomainsApp#service_params}
        /// </remarks>
        [JsiiProperty(name: "serviceParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceParams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_urn IdentityDomainsApp#service_type_urn}.</summary>
        [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceTypeUrn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_version IdentityDomainsApp#service_type_version}.</summary>
        [JsiiProperty(name: "serviceTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceTypeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#show_in_my_apps IdentityDomainsApp#show_in_my_apps}.</summary>
        [JsiiProperty(name: "showInMyApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShowInMyApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>signon_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signon_policy IdentityDomainsApp#signon_policy}
        /// </remarks>
        [JsiiProperty(name: "signonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy? SignonPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#tags IdentityDomainsApp#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_service_url IdentityDomainsApp#terms_of_service_url}.</summary>
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TermsOfServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>terms_of_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_use IdentityDomainsApp#terms_of_use}
        /// </remarks>
        [JsiiProperty(name: "termsOfUse", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse? TermsOfUse
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#timeouts IdentityDomainsApp#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>trust_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_policies IdentityDomainsApp#trust_policies}
        /// </remarks>
        [JsiiProperty(name: "trustPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrustPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_scope IdentityDomainsApp#trust_scope}.</summary>
        [JsiiProperty(name: "trustScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensiondbcs_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensiondbcs_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensiondbcs_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp? UrnietfparamsscimschemasoracleidcsextensiondbcsApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionenterprise_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp? UrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp? UrnietfparamsscimschemasoracleidcsextensionformFillAppApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate? UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp? UrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmanagedapp_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? UrnietfparamsscimschemasoracleidcsextensionmanagedappApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp? UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextension_oci_tags}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionopc_service_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionopc_service_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionopc_service_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp? UrnietfparamsscimschemasoracleidcsextensionopcServiceApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionradius_app_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionradius_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionradius_app_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp? UrnietfparamsscimschemasoracleidcsextensionradiusAppApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionrequestable_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionrequestable_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionrequestable_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp? UrnietfparamsscimschemasoracleidcsextensionrequestableApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp? UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp? UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppConfig), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>based_on_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#based_on_template IdentityDomainsApp#based_on_template}
            /// </remarks>
            [JsiiProperty(name: "basedOnTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate\"}")]
            public oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate BasedOnTemplate
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#display_name IdentityDomainsApp#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idcs_endpoint IdentityDomainsApp#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#schemas IdentityDomainsApp#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token_expiry IdentityDomainsApp#access_token_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccessTokenExpiry
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#active IdentityDomainsApp#active}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>alias_apps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#alias_apps IdentityDomainsApp#alias_apps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aliasApps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasApps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AliasApps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_access_control IdentityDomainsApp#allow_access_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowAccessControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAccessControl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_grants IdentityDomainsApp#allowed_grants}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedGrants", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedGrants
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_operations IdentityDomainsApp#allowed_operations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOperations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>allowed_scopes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_scopes IdentityDomainsApp#allowed_scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedScopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowedScopes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>allowed_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allowed_tags IdentityDomainsApp#allowed_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowedTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_offline IdentityDomainsApp#allow_offline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowOffline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowOffline
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#all_url_schemes_allowed IdentityDomainsApp#all_url_schemes_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allUrlSchemesAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllUrlSchemesAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_icon IdentityDomainsApp#app_icon}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppIcon
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>app_signon_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_signon_policy IdentityDomainsApp#app_signon_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSignonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy? AppSignonPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy?>();
            }

            /// <summary>apps_network_perimeters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#apps_network_perimeters IdentityDomainsApp#apps_network_perimeters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appsNetworkPerimeters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppsNetworkPerimeters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_thumbnail IdentityDomainsApp#app_thumbnail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppThumbnail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>as_opc_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#as_opc_service IdentityDomainsApp#as_opc_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "asOpcService", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcService\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService? AsOpcService
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attributes IdentityDomainsApp#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attribute_sets IdentityDomainsApp#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>attr_rendering_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#attr_rendering_metadata IdentityDomainsApp#attr_rendering_metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attrRenderingMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AttrRenderingMetadata
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#audience IdentityDomainsApp#audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#authorization IdentityDomainsApp#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#bypass_consent IdentityDomainsApp#bypass_consent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bypassConsent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BypassConsent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>certificates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#certificates IdentityDomainsApp#certificates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Certificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip_checking IdentityDomainsApp#client_ip_checking}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientIpChecking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientIpChecking
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_type IdentityDomainsApp#client_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#contact_email_address IdentityDomainsApp#contact_email_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contactEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContactEmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#delegated_service_names IdentityDomainsApp#delegated_service_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delegatedServiceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DelegatedServiceNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#description IdentityDomainsApp#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#disable_kmsi_token_authentication IdentityDomainsApp#disable_kmsi_token_authentication}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableKmsiTokenAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableKmsiTokenAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#error_page_url IdentityDomainsApp#error_page_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorPageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#force_delete IdentityDomainsApp#force_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#home_page_url IdentityDomainsApp#home_page_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "homePageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HomePageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#icon IdentityDomainsApp#icon}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Icon
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity_providers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#identity_providers IdentityDomainsApp#identity_providers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityProviders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProviders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityProviders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>idp_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#idp_policy IdentityDomainsApp#idp_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idpPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy? IdpPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#id_token_enc_algo IdentityDomainsApp#id_token_enc_algo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idTokenEncAlgo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdTokenEncAlgo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_alias_app IdentityDomainsApp#is_alias_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAliasApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAliasApp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_enterprise_app IdentityDomainsApp#is_enterprise_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnterpriseApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnterpriseApp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_form_fill IdentityDomainsApp#is_form_fill}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isFormFill", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFormFill
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_kerberos_realm IdentityDomainsApp#is_kerberos_realm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isKerberosRealm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsKerberosRealm
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_login_target IdentityDomainsApp#is_login_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLoginTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLoginTarget
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_mobile_target IdentityDomainsApp#is_mobile_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMobileTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMobileTarget
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_multicloud_service_app IdentityDomainsApp#is_multicloud_service_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMulticloudServiceApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMulticloudServiceApp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_client IdentityDomainsApp#is_oauth_client}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isOauthClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsOauthClient
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_oauth_resource IdentityDomainsApp#is_oauth_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isOauthResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsOauthResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_obligation_capable IdentityDomainsApp#is_obligation_capable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isObligationCapable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsObligationCapable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_radius_app IdentityDomainsApp#is_radius_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRadiusApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRadiusApp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_saml_service_provider IdentityDomainsApp#is_saml_service_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSamlServiceProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSamlServiceProvider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_unmanaged_app IdentityDomainsApp#is_unmanaged_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUnmanagedApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUnmanagedApp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_web_tier_policy IdentityDomainsApp#is_web_tier_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isWebTierPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsWebTierPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#landing_page_url IdentityDomainsApp#landing_page_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "landingPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LandingPageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#linking_callback_url IdentityDomainsApp#linking_callback_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkingCallbackUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LinkingCallbackUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_mechanism IdentityDomainsApp#login_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoginMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#login_page_url IdentityDomainsApp#login_page_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoginPageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_page_url IdentityDomainsApp#logout_page_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutPageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutPageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_uri IdentityDomainsApp#logout_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name IdentityDomainsApp#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ocid IdentityDomainsApp#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#post_logout_redirect_uris IdentityDomainsApp#post_logout_redirect_uris}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PostLogoutRedirectUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#privacy_policy_url IdentityDomainsApp#privacy_policy_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivacyPolicyUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_logo_url IdentityDomainsApp#product_logo_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "productLogoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductLogoUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#product_name IdentityDomainsApp#product_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>protectable_secondary_audiences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#protectable_secondary_audiences IdentityDomainsApp#protectable_secondary_audiences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protectableSecondaryAudiences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProtectableSecondaryAudiences
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>radius_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_policy IdentityDomainsApp#radius_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "radiusPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy? RadiusPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#redirect_uris IdentityDomainsApp#redirect_uris}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RedirectUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#refresh_token_expiry IdentityDomainsApp#refresh_token_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshTokenExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RefreshTokenExpiry
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_type_schema_version IdentityDomainsApp#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>saml_service_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#saml_service_provider IdentityDomainsApp#saml_service_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samlServiceProvider", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProvider\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider? SamlServiceProvider
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider?>();
            }

            /// <summary>scopes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#scopes IdentityDomainsApp#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Scopes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secondary_audiences IdentityDomainsApp#secondary_audiences}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecondaryAudiences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>service_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_params IdentityDomainsApp#service_params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServiceParams
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_urn IdentityDomainsApp#service_type_urn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceTypeUrn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_type_version IdentityDomainsApp#service_type_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceTypeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#show_in_my_apps IdentityDomainsApp#show_in_my_apps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "showInMyApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShowInMyApps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>signon_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signon_policy IdentityDomainsApp#signon_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy? SignonPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#tags IdentityDomainsApp#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_service_url IdentityDomainsApp#terms_of_service_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>terms_of_use block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#terms_of_use IdentityDomainsApp#terms_of_use}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfUse", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUse\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse? TermsOfUse
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#timeouts IdentityDomainsApp#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts?>();
            }

            /// <summary>trust_policies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_policies IdentityDomainsApp#trust_policies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrustPolicies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#trust_scope IdentityDomainsApp#trust_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensiondbcs_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensiondbcs_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensiondbcs_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp? UrnietfparamsscimschemasoracleidcsextensiondbcsApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionenterprise_app_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionenterprise_app_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp? UrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp? UrnietfparamsscimschemasoracleidcsextensionformFillAppApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionform_fill_app_template_app_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate? UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionkerberos_realm_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp? UrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionmanagedapp_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmanagedapp_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? UrnietfparamsscimschemasoracleidcsextensionmanagedappApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionmulticloud_service_app_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp? UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextension_oci_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionopc_service_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionopc_service_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionopc_service_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp? UrnietfparamsscimschemasoracleidcsextensionopcServiceApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionradius_app_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionradius_app_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionradius_app_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp? UrnietfparamsscimschemasoracleidcsextensionradiusAppApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionrequestable_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionrequestable_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionrequestable_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp? UrnietfparamsscimschemasoracleidcsextensionrequestableApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionsaml_service_provider_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp? UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app IdentityDomainsApp#urnietfparamsscimschemasoracleidcsextensionweb_tier_policy_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp? UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
