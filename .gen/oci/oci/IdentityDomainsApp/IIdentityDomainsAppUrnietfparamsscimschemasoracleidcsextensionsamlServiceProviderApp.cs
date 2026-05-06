using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#assertion_consumer_url IdentityDomainsApp#assertion_consumer_url}.</summary>
        [JsiiProperty(name: "assertionConsumerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssertionConsumerUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encrypt_assertion IdentityDomainsApp#encrypt_assertion}.</summary>
        [JsiiProperty(name: "encryptAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptAssertion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_algorithm IdentityDomainsApp#encryption_algorithm}.</summary>
        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_certificate IdentityDomainsApp#encryption_certificate}.</summary>
        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#federation_protocol IdentityDomainsApp#federation_protocol}.</summary>
        [JsiiProperty(name: "federationProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FederationProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>group_assertion_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_assertion_attributes IdentityDomainsApp#group_assertion_attributes}
        /// </remarks>
        [JsiiProperty(name: "groupAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GroupAssertionAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_acs_url IdentityDomainsApp#hok_acs_url}.</summary>
        [JsiiProperty(name: "hokAcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HokAcsUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_required IdentityDomainsApp#hok_required}.</summary>
        [JsiiProperty(name: "hokRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HokRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_signing_cert_in_signature IdentityDomainsApp#include_signing_cert_in_signature}.</summary>
        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeSigningCertInSignature
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#key_encryption_algorithm IdentityDomainsApp#key_encryption_algorithm}.</summary>
        [JsiiProperty(name: "keyEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyEncryptionAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_binding IdentityDomainsApp#logout_binding}.</summary>
        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutBinding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_enabled IdentityDomainsApp#logout_enabled}.</summary>
        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogoutEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_request_url IdentityDomainsApp#logout_request_url}.</summary>
        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutRequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_response_url IdentityDomainsApp#logout_response_url}.</summary>
        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutResponseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#metadata IdentityDomainsApp#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_format IdentityDomainsApp#name_id_format}.</summary>
        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameIdFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_userstore_attribute IdentityDomainsApp#name_id_userstore_attribute}.</summary>
        [JsiiProperty(name: "nameIdUserstoreAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameIdUserstoreAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_id IdentityDomainsApp#partner_provider_id}.</summary>
        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerProviderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_pattern IdentityDomainsApp#partner_provider_pattern}.</summary>
        [JsiiProperty(name: "partnerProviderPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerProviderPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signature_hash_algorithm IdentityDomainsApp#signature_hash_algorithm}.</summary>
        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignatureHashAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signing_certificate IdentityDomainsApp#signing_certificate}.</summary>
        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SigningCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sign_response_or_assertion IdentityDomainsApp#sign_response_or_assertion}.</summary>
        [JsiiProperty(name: "signResponseOrAssertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignResponseOrAssertion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#succinct_id IdentityDomainsApp#succinct_id}.</summary>
        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccinctId
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_assertion_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_assertion_attributes IdentityDomainsApp#user_assertion_attributes}
        /// </remarks>
        [JsiiProperty(name: "userAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserAssertionAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#assertion_consumer_url IdentityDomainsApp#assertion_consumer_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assertionConsumerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssertionConsumerUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encrypt_assertion IdentityDomainsApp#encrypt_assertion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EncryptAssertion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_algorithm IdentityDomainsApp#encryption_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_certificate IdentityDomainsApp#encryption_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#federation_protocol IdentityDomainsApp#federation_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "federationProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FederationProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>group_assertion_attributes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_assertion_attributes IdentityDomainsApp#group_assertion_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GroupAssertionAttributes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_acs_url IdentityDomainsApp#hok_acs_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hokAcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HokAcsUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_required IdentityDomainsApp#hok_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hokRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HokRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_signing_cert_in_signature IdentityDomainsApp#include_signing_cert_in_signature}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeSigningCertInSignature
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#key_encryption_algorithm IdentityDomainsApp#key_encryption_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyEncryptionAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_binding IdentityDomainsApp#logout_binding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutBinding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_enabled IdentityDomainsApp#logout_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogoutEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_request_url IdentityDomainsApp#logout_request_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutRequestUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_response_url IdentityDomainsApp#logout_response_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutResponseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#metadata IdentityDomainsApp#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_format IdentityDomainsApp#name_id_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameIdFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_userstore_attribute IdentityDomainsApp#name_id_userstore_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nameIdUserstoreAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameIdUserstoreAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_id IdentityDomainsApp#partner_provider_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerProviderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_pattern IdentityDomainsApp#partner_provider_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partnerProviderPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerProviderPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signature_hash_algorithm IdentityDomainsApp#signature_hash_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignatureHashAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signing_certificate IdentityDomainsApp#signing_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SigningCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sign_response_or_assertion IdentityDomainsApp#sign_response_or_assertion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signResponseOrAssertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignResponseOrAssertion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#succinct_id IdentityDomainsApp#succinct_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccinctId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>user_assertion_attributes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_assertion_attributes IdentityDomainsApp#user_assertion_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserAssertionAttributes
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
