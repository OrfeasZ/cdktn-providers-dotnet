using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#assertion_consumer_url IdentityDomainsApp#assertion_consumer_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assertionConsumerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssertionConsumerUrl
        {
            get;
            set;
        }

        private object? _encryptAssertion;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encrypt_assertion IdentityDomainsApp#encrypt_assertion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EncryptAssertion
        {
            get => _encryptAssertion;
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
                _encryptAssertion = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_algorithm IdentityDomainsApp#encryption_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#encryption_certificate IdentityDomainsApp#encryption_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#federation_protocol IdentityDomainsApp#federation_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "federationProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FederationProtocol
        {
            get;
            set;
        }

        private object? _groupAssertionAttributes;

        /// <summary>group_assertion_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_assertion_attributes IdentityDomainsApp#group_assertion_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GroupAssertionAttributes
        {
            get => _groupAssertionAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groupAssertionAttributes = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_acs_url IdentityDomainsApp#hok_acs_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hokAcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HokAcsUrl
        {
            get;
            set;
        }

        private object? _hokRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#hok_required IdentityDomainsApp#hok_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hokRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HokRequired
        {
            get => _hokRequired;
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
                _hokRequired = value;
            }
        }

        private object? _includeSigningCertInSignature;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_signing_cert_in_signature IdentityDomainsApp#include_signing_cert_in_signature}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeSigningCertInSignature
        {
            get => _includeSigningCertInSignature;
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
                _includeSigningCertInSignature = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#key_encryption_algorithm IdentityDomainsApp#key_encryption_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyEncryptionAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_binding IdentityDomainsApp#logout_binding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutBinding
        {
            get;
            set;
        }

        private object? _logoutEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_enabled IdentityDomainsApp#logout_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? LogoutEnabled
        {
            get => _logoutEnabled;
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
                _logoutEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_request_url IdentityDomainsApp#logout_request_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutRequestUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#logout_response_url IdentityDomainsApp#logout_response_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutResponseUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#metadata IdentityDomainsApp#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_format IdentityDomainsApp#name_id_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameIdFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name_id_userstore_attribute IdentityDomainsApp#name_id_userstore_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameIdUserstoreAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameIdUserstoreAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_id IdentityDomainsApp#partner_provider_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PartnerProviderId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#partner_provider_pattern IdentityDomainsApp#partner_provider_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partnerProviderPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PartnerProviderPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signature_hash_algorithm IdentityDomainsApp#signature_hash_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignatureHashAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#signing_certificate IdentityDomainsApp#signing_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SigningCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sign_response_or_assertion IdentityDomainsApp#sign_response_or_assertion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signResponseOrAssertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignResponseOrAssertion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#succinct_id IdentityDomainsApp#succinct_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SuccinctId
        {
            get;
            set;
        }

        private object? _userAssertionAttributes;

        /// <summary>user_assertion_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_assertion_attributes IdentityDomainsApp#user_assertion_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAssertionAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UserAssertionAttributes
        {
            get => _userAssertionAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userAssertionAttributes = value;
            }
        }
    }
}
