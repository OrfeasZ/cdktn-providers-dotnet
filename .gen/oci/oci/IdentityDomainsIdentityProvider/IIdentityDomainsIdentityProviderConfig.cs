using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProviderConfig), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderConfig")]
    public interface IIdentityDomainsIdentityProviderConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#enabled IdentityDomainsIdentityProvider#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idcs_endpoint IdentityDomainsIdentityProvider#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#partner_name IdentityDomainsIdentityProvider#partner_name}.</summary>
        [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
        string PartnerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#schemas IdentityDomainsIdentityProvider#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#assertion_attribute IdentityDomainsIdentityProvider#assertion_attribute}.</summary>
        [JsiiProperty(name: "assertionAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssertionAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#attributes IdentityDomainsIdentityProvider#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#attribute_sets IdentityDomainsIdentityProvider#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#authn_request_binding IdentityDomainsIdentityProvider#authn_request_binding}.</summary>
        [JsiiProperty(name: "authnRequestBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthnRequestBinding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#authorization IdentityDomainsIdentityProvider#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>correlation_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#correlation_policy IdentityDomainsIdentityProvider#correlation_policy}
        /// </remarks>
        [JsiiProperty(name: "correlationPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy? CorrelationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#description IdentityDomainsIdentityProvider#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#encryption_certificate IdentityDomainsIdentityProvider#encryption_certificate}.</summary>
        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#external_id IdentityDomainsIdentityProvider#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#icon_url IdentityDomainsIdentityProvider#icon_url}.</summary>
        [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IconUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idp_sso_url IdentityDomainsIdentityProvider#idp_sso_url}.</summary>
        [JsiiProperty(name: "idpSsoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdpSsoUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#include_signing_cert_in_signature IdentityDomainsIdentityProvider#include_signing_cert_in_signature}.</summary>
        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeSigningCertInSignature
        {
            get
            {
                return null;
            }
        }

        /// <summary>jit_user_prov_assigned_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_assigned_groups IdentityDomainsIdentityProvider#jit_user_prov_assigned_groups}
        /// </remarks>
        [JsiiProperty(name: "jitUserProvAssignedGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvAssignedGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>jit_user_prov_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_attributes IdentityDomainsIdentityProvider#jit_user_prov_attributes}
        /// </remarks>
        [JsiiProperty(name: "jitUserProvAttributes", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes? JitUserProvAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_attribute_update_enabled IdentityDomainsIdentityProvider#jit_user_prov_attribute_update_enabled}.</summary>
        [JsiiProperty(name: "jitUserProvAttributeUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvAttributeUpdateEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_create_user_enabled IdentityDomainsIdentityProvider#jit_user_prov_create_user_enabled}.</summary>
        [JsiiProperty(name: "jitUserProvCreateUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvCreateUserEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_enabled IdentityDomainsIdentityProvider#jit_user_prov_enabled}.</summary>
        [JsiiProperty(name: "jitUserProvEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_assertion_attribute_enabled IdentityDomainsIdentityProvider#jit_user_prov_group_assertion_attribute_enabled}.</summary>
        [JsiiProperty(name: "jitUserProvGroupAssertionAttributeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvGroupAssertionAttributeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_assignment_method IdentityDomainsIdentityProvider#jit_user_prov_group_assignment_method}.</summary>
        [JsiiProperty(name: "jitUserProvGroupAssignmentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JitUserProvGroupAssignmentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_mapping_mode IdentityDomainsIdentityProvider#jit_user_prov_group_mapping_mode}.</summary>
        [JsiiProperty(name: "jitUserProvGroupMappingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JitUserProvGroupMappingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>jit_user_prov_group_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_mappings IdentityDomainsIdentityProvider#jit_user_prov_group_mappings}
        /// </remarks>
        [JsiiProperty(name: "jitUserProvGroupMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvGroupMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_saml_attribute_name IdentityDomainsIdentityProvider#jit_user_prov_group_saml_attribute_name}.</summary>
        [JsiiProperty(name: "jitUserProvGroupSamlAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JitUserProvGroupSamlAttributeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_static_list_enabled IdentityDomainsIdentityProvider#jit_user_prov_group_static_list_enabled}.</summary>
        [JsiiProperty(name: "jitUserProvGroupStaticListEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvGroupStaticListEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_ignore_error_on_absent_groups IdentityDomainsIdentityProvider#jit_user_prov_ignore_error_on_absent_groups}.</summary>
        [JsiiProperty(name: "jitUserProvIgnoreErrorOnAbsentGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JitUserProvIgnoreErrorOnAbsentGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_binding IdentityDomainsIdentityProvider#logout_binding}.</summary>
        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutBinding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_enabled IdentityDomainsIdentityProvider#logout_enabled}.</summary>
        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogoutEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_request_url IdentityDomainsIdentityProvider#logout_request_url}.</summary>
        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutRequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_response_url IdentityDomainsIdentityProvider#logout_response_url}.</summary>
        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutResponseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#metadata IdentityDomainsIdentityProvider#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#name_id_format IdentityDomainsIdentityProvider#name_id_format}.</summary>
        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameIdFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocid IdentityDomainsIdentityProvider#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#partner_provider_id IdentityDomainsIdentityProvider#partner_provider_id}.</summary>
        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerProviderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#requested_authentication_context IdentityDomainsIdentityProvider#requested_authentication_context}.</summary>
        [JsiiProperty(name: "requestedAuthenticationContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RequestedAuthenticationContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#require_force_authn IdentityDomainsIdentityProvider#require_force_authn}.</summary>
        [JsiiProperty(name: "requireForceAuthn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireForceAuthn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#requires_encrypted_assertion IdentityDomainsIdentityProvider#requires_encrypted_assertion}.</summary>
        [JsiiProperty(name: "requiresEncryptedAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequiresEncryptedAssertion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#resource_type_schema_version IdentityDomainsIdentityProvider#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#saml_ho_krequired IdentityDomainsIdentityProvider#saml_ho_krequired}.</summary>
        [JsiiProperty(name: "samlHoKrequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SamlHoKrequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#service_instance_identifier IdentityDomainsIdentityProvider#service_instance_identifier}.</summary>
        [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceInstanceIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#shown_on_login_page IdentityDomainsIdentityProvider#shown_on_login_page}.</summary>
        [JsiiProperty(name: "shownOnLoginPage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShownOnLoginPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signature_hash_algorithm IdentityDomainsIdentityProvider#signature_hash_algorithm}.</summary>
        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignatureHashAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signing_certificate IdentityDomainsIdentityProvider#signing_certificate}.</summary>
        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SigningCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#succinct_id IdentityDomainsIdentityProvider#succinct_id}.</summary>
        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccinctId
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#tags IdentityDomainsIdentityProvider#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#timeouts IdentityDomainsIdentityProvider#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#type IdentityDomainsIdentityProvider#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider IdentityDomainsIdentityProvider#urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider? UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionx509identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#urnietfparamsscimschemasoracleidcsextensionx509identity_provider IdentityDomainsIdentityProvider#urnietfparamsscimschemasoracleidcsextensionx509identity_provider}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider? Urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_mapping_method IdentityDomainsIdentityProvider#user_mapping_method}.</summary>
        [JsiiProperty(name: "userMappingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserMappingMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_mapping_store_attribute IdentityDomainsIdentityProvider#user_mapping_store_attribute}.</summary>
        [JsiiProperty(name: "userMappingStoreAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserMappingStoreAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProviderConfig), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#enabled IdentityDomainsIdentityProvider#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idcs_endpoint IdentityDomainsIdentityProvider#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#partner_name IdentityDomainsIdentityProvider#partner_name}.</summary>
            [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
            public string PartnerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#schemas IdentityDomainsIdentityProvider#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#assertion_attribute IdentityDomainsIdentityProvider#assertion_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assertionAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssertionAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#attributes IdentityDomainsIdentityProvider#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#attribute_sets IdentityDomainsIdentityProvider#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#authn_request_binding IdentityDomainsIdentityProvider#authn_request_binding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authnRequestBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthnRequestBinding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#authorization IdentityDomainsIdentityProvider#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>correlation_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#correlation_policy IdentityDomainsIdentityProvider#correlation_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "correlationPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy? CorrelationPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#description IdentityDomainsIdentityProvider#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#encryption_certificate IdentityDomainsIdentityProvider#encryption_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#external_id IdentityDomainsIdentityProvider#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#icon_url IdentityDomainsIdentityProvider#icon_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IconUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idp_sso_url IdentityDomainsIdentityProvider#idp_sso_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idpSsoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdpSsoUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#include_signing_cert_in_signature IdentityDomainsIdentityProvider#include_signing_cert_in_signature}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeSigningCertInSignature
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>jit_user_prov_assigned_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_assigned_groups IdentityDomainsIdentityProvider#jit_user_prov_assigned_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvAssignedGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JitUserProvAssignedGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>jit_user_prov_attributes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_attributes IdentityDomainsIdentityProvider#jit_user_prov_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvAttributes", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes? JitUserProvAttributes
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_attribute_update_enabled IdentityDomainsIdentityProvider#jit_user_prov_attribute_update_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvAttributeUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvAttributeUpdateEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_create_user_enabled IdentityDomainsIdentityProvider#jit_user_prov_create_user_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvCreateUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvCreateUserEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_enabled IdentityDomainsIdentityProvider#jit_user_prov_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_assertion_attribute_enabled IdentityDomainsIdentityProvider#jit_user_prov_group_assertion_attribute_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupAssertionAttributeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvGroupAssertionAttributeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_assignment_method IdentityDomainsIdentityProvider#jit_user_prov_group_assignment_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupAssignmentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JitUserProvGroupAssignmentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_mapping_mode IdentityDomainsIdentityProvider#jit_user_prov_group_mapping_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupMappingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JitUserProvGroupMappingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>jit_user_prov_group_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_mappings IdentityDomainsIdentityProvider#jit_user_prov_group_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JitUserProvGroupMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_saml_attribute_name IdentityDomainsIdentityProvider#jit_user_prov_group_saml_attribute_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupSamlAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JitUserProvGroupSamlAttributeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_group_static_list_enabled IdentityDomainsIdentityProvider#jit_user_prov_group_static_list_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvGroupStaticListEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvGroupStaticListEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#jit_user_prov_ignore_error_on_absent_groups IdentityDomainsIdentityProvider#jit_user_prov_ignore_error_on_absent_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jitUserProvIgnoreErrorOnAbsentGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JitUserProvIgnoreErrorOnAbsentGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_binding IdentityDomainsIdentityProvider#logout_binding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutBinding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_enabled IdentityDomainsIdentityProvider#logout_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogoutEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_request_url IdentityDomainsIdentityProvider#logout_request_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutRequestUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#logout_response_url IdentityDomainsIdentityProvider#logout_response_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutResponseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#metadata IdentityDomainsIdentityProvider#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#name_id_format IdentityDomainsIdentityProvider#name_id_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameIdFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocid IdentityDomainsIdentityProvider#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#partner_provider_id IdentityDomainsIdentityProvider#partner_provider_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerProviderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#requested_authentication_context IdentityDomainsIdentityProvider#requested_authentication_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestedAuthenticationContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RequestedAuthenticationContext
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#require_force_authn IdentityDomainsIdentityProvider#require_force_authn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireForceAuthn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireForceAuthn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#requires_encrypted_assertion IdentityDomainsIdentityProvider#requires_encrypted_assertion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requiresEncryptedAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequiresEncryptedAssertion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#resource_type_schema_version IdentityDomainsIdentityProvider#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#saml_ho_krequired IdentityDomainsIdentityProvider#saml_ho_krequired}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "samlHoKrequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SamlHoKrequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#service_instance_identifier IdentityDomainsIdentityProvider#service_instance_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceInstanceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#shown_on_login_page IdentityDomainsIdentityProvider#shown_on_login_page}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shownOnLoginPage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShownOnLoginPage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signature_hash_algorithm IdentityDomainsIdentityProvider#signature_hash_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignatureHashAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signing_certificate IdentityDomainsIdentityProvider#signing_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SigningCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#succinct_id IdentityDomainsIdentityProvider#succinct_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccinctId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#tags IdentityDomainsIdentityProvider#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#timeouts IdentityDomainsIdentityProvider#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#type IdentityDomainsIdentityProvider#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider IdentityDomainsIdentityProvider#urnietfparamsscimschemasoracleidcsextensionsocial_identity_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider? UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionx509identity_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#urnietfparamsscimschemasoracleidcsextensionx509identity_provider IdentityDomainsIdentityProvider#urnietfparamsscimschemasoracleidcsextensionx509identity_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider? Urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_mapping_method IdentityDomainsIdentityProvider#user_mapping_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userMappingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserMappingMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_mapping_store_attribute IdentityDomainsIdentityProvider#user_mapping_store_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userMappingStoreAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserMappingStoreAttribute
            {
                get => GetInstanceProperty<string?>();
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
