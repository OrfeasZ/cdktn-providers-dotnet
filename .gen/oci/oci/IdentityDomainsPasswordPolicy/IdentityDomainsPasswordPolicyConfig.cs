using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPasswordPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyConfig")]
    public class IdentityDomainsPasswordPolicyConfig : oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#idcs_endpoint IdentityDomainsPasswordPolicy#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#name IdentityDomainsPasswordPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#schemas IdentityDomainsPasswordPolicy#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Schemas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#allowed_chars IdentityDomainsPasswordPolicy#allowed_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowedChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attributes IdentityDomainsPasswordPolicy#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attribute_sets IdentityDomainsPasswordPolicy#attribute_sets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeSets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#authorization IdentityDomainsPasswordPolicy#authorization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Authorization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#description IdentityDomainsPasswordPolicy#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_delimiter IdentityDomainsPasswordPolicy#dictionary_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dictionaryDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DictionaryDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_location IdentityDomainsPasswordPolicy#dictionary_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dictionaryLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DictionaryLocation
        {
            get;
            set;
        }

        private object? _dictionaryWordDisallowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_word_disallowed IdentityDomainsPasswordPolicy#dictionary_word_disallowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dictionaryWordDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DictionaryWordDisallowed
        {
            get => _dictionaryWordDisallowed;
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
                _dictionaryWordDisallowed = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_chars IdentityDomainsPasswordPolicy#disallowed_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disallowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisallowedChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_substrings IdentityDomainsPasswordPolicy#disallowed_substrings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disallowedSubstrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DisallowedSubstrings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_user_attribute_values IdentityDomainsPasswordPolicy#disallowed_user_attribute_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disallowedUserAttributeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DisallowedUserAttributeValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#distinct_characters IdentityDomainsPasswordPolicy#distinct_characters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distinctCharacters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DistinctCharacters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#external_id IdentityDomainsPasswordPolicy#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        private object? _firstNameDisallowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#first_name_disallowed IdentityDomainsPasswordPolicy#first_name_disallowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FirstNameDisallowed
        {
            get => _firstNameDisallowed;
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
                _firstNameDisallowed = value;
            }
        }

        private object? _forcePasswordReset;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#force_password_reset IdentityDomainsPasswordPolicy#force_password_reset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forcePasswordReset", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ForcePasswordReset
        {
            get => _forcePasswordReset;
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
                _forcePasswordReset = value;
            }
        }

        private object? _groups;

        /// <summary>groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#groups IdentityDomainsPasswordPolicy#groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Groups
        {
            get => _groups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groups = value;
            }
        }

        private object? _lastNameDisallowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#last_name_disallowed IdentityDomainsPasswordPolicy#last_name_disallowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? LastNameDisallowed
        {
            get => _lastNameDisallowed;
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
                _lastNameDisallowed = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#lockout_duration IdentityDomainsPasswordPolicy#lockout_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lockoutDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LockoutDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_incorrect_attempts IdentityDomainsPasswordPolicy#max_incorrect_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIncorrectAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIncorrectAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_length IdentityDomainsPasswordPolicy#max_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_repeated_chars IdentityDomainsPasswordPolicy#max_repeated_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRepeatedChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRepeatedChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_special_chars IdentityDomainsPasswordPolicy#max_special_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSpecialChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alpha_numerals IdentityDomainsPasswordPolicy#min_alpha_numerals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAlphaNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAlphaNumerals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alphas IdentityDomainsPasswordPolicy#min_alphas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAlphas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAlphas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_length IdentityDomainsPasswordPolicy#min_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_lower_case IdentityDomainsPasswordPolicy#min_lower_case}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minLowerCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinLowerCase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_numerals IdentityDomainsPasswordPolicy#min_numerals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinNumerals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_password_age IdentityDomainsPasswordPolicy#min_password_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinPasswordAge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_special_chars IdentityDomainsPasswordPolicy#min_special_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSpecialChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_unique_chars IdentityDomainsPasswordPolicy#min_unique_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minUniqueChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinUniqueChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_upper_case IdentityDomainsPasswordPolicy#min_upper_case}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minUpperCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinUpperCase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#num_passwords_in_history IdentityDomainsPasswordPolicy#num_passwords_in_history}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numPasswordsInHistory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumPasswordsInHistory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#ocid IdentityDomainsPasswordPolicy#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expires_after IdentityDomainsPasswordPolicy#password_expires_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordExpiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PasswordExpiresAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expire_warning IdentityDomainsPasswordPolicy#password_expire_warning}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordExpireWarning", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PasswordExpireWarning
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_strength IdentityDomainsPasswordPolicy#password_strength}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordStrength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordStrength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#priority IdentityDomainsPasswordPolicy#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#required_chars IdentityDomainsPasswordPolicy#required_chars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiredChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequiredChars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#resource_type_schema_version IdentityDomainsPasswordPolicy#resource_type_schema_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTypeSchemaVersion
        {
            get;
            set;
        }

        private object? _startsWithAlphabet;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#starts_with_alphabet IdentityDomainsPasswordPolicy#starts_with_alphabet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startsWithAlphabet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StartsWithAlphabet
        {
            get => _startsWithAlphabet;
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
                _startsWithAlphabet = value;
            }
        }

        private object? _tags;

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#tags IdentityDomainsPasswordPolicy#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#timeouts IdentityDomainsPasswordPolicy#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTimeouts\"}", isOptional: true)]
        public oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _userNameDisallowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#user_name_disallowed IdentityDomainsPasswordPolicy#user_name_disallowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UserNameDisallowed
        {
            get => _userNameDisallowed;
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
                _userNameDisallowed = value;
            }
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
