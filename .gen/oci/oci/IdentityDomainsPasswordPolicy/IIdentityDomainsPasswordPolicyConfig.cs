using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPasswordPolicy
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsPasswordPolicyConfig), fullyQualifiedName: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyConfig")]
    public interface IIdentityDomainsPasswordPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#idcs_endpoint IdentityDomainsPasswordPolicy#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#name IdentityDomainsPasswordPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#schemas IdentityDomainsPasswordPolicy#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#allowed_chars IdentityDomainsPasswordPolicy#allowed_chars}.</summary>
        [JsiiProperty(name: "allowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attributes IdentityDomainsPasswordPolicy#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attribute_sets IdentityDomainsPasswordPolicy#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#authorization IdentityDomainsPasswordPolicy#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#description IdentityDomainsPasswordPolicy#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_delimiter IdentityDomainsPasswordPolicy#dictionary_delimiter}.</summary>
        [JsiiProperty(name: "dictionaryDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DictionaryDelimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_location IdentityDomainsPasswordPolicy#dictionary_location}.</summary>
        [JsiiProperty(name: "dictionaryLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DictionaryLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_word_disallowed IdentityDomainsPasswordPolicy#dictionary_word_disallowed}.</summary>
        [JsiiProperty(name: "dictionaryWordDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DictionaryWordDisallowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_chars IdentityDomainsPasswordPolicy#disallowed_chars}.</summary>
        [JsiiProperty(name: "disallowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisallowedChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_substrings IdentityDomainsPasswordPolicy#disallowed_substrings}.</summary>
        [JsiiProperty(name: "disallowedSubstrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DisallowedSubstrings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_user_attribute_values IdentityDomainsPasswordPolicy#disallowed_user_attribute_values}.</summary>
        [JsiiProperty(name: "disallowedUserAttributeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DisallowedUserAttributeValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#distinct_characters IdentityDomainsPasswordPolicy#distinct_characters}.</summary>
        [JsiiProperty(name: "distinctCharacters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DistinctCharacters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#external_id IdentityDomainsPasswordPolicy#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#first_name_disallowed IdentityDomainsPasswordPolicy#first_name_disallowed}.</summary>
        [JsiiProperty(name: "firstNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirstNameDisallowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#force_password_reset IdentityDomainsPasswordPolicy#force_password_reset}.</summary>
        [JsiiProperty(name: "forcePasswordReset", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForcePasswordReset
        {
            get
            {
                return null;
            }
        }

        /// <summary>groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#groups IdentityDomainsPasswordPolicy#groups}
        /// </remarks>
        [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Groups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#last_name_disallowed IdentityDomainsPasswordPolicy#last_name_disallowed}.</summary>
        [JsiiProperty(name: "lastNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastNameDisallowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#lockout_duration IdentityDomainsPasswordPolicy#lockout_duration}.</summary>
        [JsiiProperty(name: "lockoutDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LockoutDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_incorrect_attempts IdentityDomainsPasswordPolicy#max_incorrect_attempts}.</summary>
        [JsiiProperty(name: "maxIncorrectAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIncorrectAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_length IdentityDomainsPasswordPolicy#max_length}.</summary>
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_repeated_chars IdentityDomainsPasswordPolicy#max_repeated_chars}.</summary>
        [JsiiProperty(name: "maxRepeatedChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRepeatedChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_special_chars IdentityDomainsPasswordPolicy#max_special_chars}.</summary>
        [JsiiProperty(name: "maxSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSpecialChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alpha_numerals IdentityDomainsPasswordPolicy#min_alpha_numerals}.</summary>
        [JsiiProperty(name: "minAlphaNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAlphaNumerals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alphas IdentityDomainsPasswordPolicy#min_alphas}.</summary>
        [JsiiProperty(name: "minAlphas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAlphas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_length IdentityDomainsPasswordPolicy#min_length}.</summary>
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_lower_case IdentityDomainsPasswordPolicy#min_lower_case}.</summary>
        [JsiiProperty(name: "minLowerCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinLowerCase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_numerals IdentityDomainsPasswordPolicy#min_numerals}.</summary>
        [JsiiProperty(name: "minNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinNumerals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_password_age IdentityDomainsPasswordPolicy#min_password_age}.</summary>
        [JsiiProperty(name: "minPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinPasswordAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_special_chars IdentityDomainsPasswordPolicy#min_special_chars}.</summary>
        [JsiiProperty(name: "minSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSpecialChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_unique_chars IdentityDomainsPasswordPolicy#min_unique_chars}.</summary>
        [JsiiProperty(name: "minUniqueChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinUniqueChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_upper_case IdentityDomainsPasswordPolicy#min_upper_case}.</summary>
        [JsiiProperty(name: "minUpperCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinUpperCase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#num_passwords_in_history IdentityDomainsPasswordPolicy#num_passwords_in_history}.</summary>
        [JsiiProperty(name: "numPasswordsInHistory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumPasswordsInHistory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#ocid IdentityDomainsPasswordPolicy#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expires_after IdentityDomainsPasswordPolicy#password_expires_after}.</summary>
        [JsiiProperty(name: "passwordExpiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordExpiresAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expire_warning IdentityDomainsPasswordPolicy#password_expire_warning}.</summary>
        [JsiiProperty(name: "passwordExpireWarning", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordExpireWarning
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_strength IdentityDomainsPasswordPolicy#password_strength}.</summary>
        [JsiiProperty(name: "passwordStrength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordStrength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#priority IdentityDomainsPasswordPolicy#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#required_chars IdentityDomainsPasswordPolicy#required_chars}.</summary>
        [JsiiProperty(name: "requiredChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequiredChars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#resource_type_schema_version IdentityDomainsPasswordPolicy#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#starts_with_alphabet IdentityDomainsPasswordPolicy#starts_with_alphabet}.</summary>
        [JsiiProperty(name: "startsWithAlphabet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StartsWithAlphabet
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#tags IdentityDomainsPasswordPolicy#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#timeouts IdentityDomainsPasswordPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#user_name_disallowed IdentityDomainsPasswordPolicy#user_name_disallowed}.</summary>
        [JsiiProperty(name: "userNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserNameDisallowed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsPasswordPolicyConfig), fullyQualifiedName: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#idcs_endpoint IdentityDomainsPasswordPolicy#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#name IdentityDomainsPasswordPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#schemas IdentityDomainsPasswordPolicy#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#allowed_chars IdentityDomainsPasswordPolicy#allowed_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedChars
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attributes IdentityDomainsPasswordPolicy#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#attribute_sets IdentityDomainsPasswordPolicy#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#authorization IdentityDomainsPasswordPolicy#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#description IdentityDomainsPasswordPolicy#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_delimiter IdentityDomainsPasswordPolicy#dictionary_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dictionaryDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DictionaryDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_location IdentityDomainsPasswordPolicy#dictionary_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dictionaryLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DictionaryLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#dictionary_word_disallowed IdentityDomainsPasswordPolicy#dictionary_word_disallowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dictionaryWordDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DictionaryWordDisallowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_chars IdentityDomainsPasswordPolicy#disallowed_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disallowedChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisallowedChars
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_substrings IdentityDomainsPasswordPolicy#disallowed_substrings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disallowedSubstrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DisallowedSubstrings
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#disallowed_user_attribute_values IdentityDomainsPasswordPolicy#disallowed_user_attribute_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disallowedUserAttributeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DisallowedUserAttributeValues
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#distinct_characters IdentityDomainsPasswordPolicy#distinct_characters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "distinctCharacters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DistinctCharacters
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#external_id IdentityDomainsPasswordPolicy#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#first_name_disallowed IdentityDomainsPasswordPolicy#first_name_disallowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FirstNameDisallowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#force_password_reset IdentityDomainsPasswordPolicy#force_password_reset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forcePasswordReset", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForcePasswordReset
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#groups IdentityDomainsPasswordPolicy#groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Groups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#last_name_disallowed IdentityDomainsPasswordPolicy#last_name_disallowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LastNameDisallowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#lockout_duration IdentityDomainsPasswordPolicy#lockout_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lockoutDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LockoutDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_incorrect_attempts IdentityDomainsPasswordPolicy#max_incorrect_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxIncorrectAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIncorrectAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_length IdentityDomainsPasswordPolicy#max_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_repeated_chars IdentityDomainsPasswordPolicy#max_repeated_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRepeatedChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRepeatedChars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#max_special_chars IdentityDomainsPasswordPolicy#max_special_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSpecialChars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alpha_numerals IdentityDomainsPasswordPolicy#min_alpha_numerals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minAlphaNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAlphaNumerals
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_alphas IdentityDomainsPasswordPolicy#min_alphas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minAlphas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAlphas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_length IdentityDomainsPasswordPolicy#min_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_lower_case IdentityDomainsPasswordPolicy#min_lower_case}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minLowerCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinLowerCase
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_numerals IdentityDomainsPasswordPolicy#min_numerals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minNumerals", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinNumerals
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_password_age IdentityDomainsPasswordPolicy#min_password_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinPasswordAge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_special_chars IdentityDomainsPasswordPolicy#min_special_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSpecialChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSpecialChars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_unique_chars IdentityDomainsPasswordPolicy#min_unique_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minUniqueChars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinUniqueChars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#min_upper_case IdentityDomainsPasswordPolicy#min_upper_case}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minUpperCase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinUpperCase
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#num_passwords_in_history IdentityDomainsPasswordPolicy#num_passwords_in_history}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numPasswordsInHistory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumPasswordsInHistory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#ocid IdentityDomainsPasswordPolicy#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expires_after IdentityDomainsPasswordPolicy#password_expires_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordExpiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordExpiresAfter
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_expire_warning IdentityDomainsPasswordPolicy#password_expire_warning}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordExpireWarning", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordExpireWarning
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#password_strength IdentityDomainsPasswordPolicy#password_strength}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordStrength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordStrength
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#priority IdentityDomainsPasswordPolicy#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#required_chars IdentityDomainsPasswordPolicy#required_chars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requiredChars", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequiredChars
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#resource_type_schema_version IdentityDomainsPasswordPolicy#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#starts_with_alphabet IdentityDomainsPasswordPolicy#starts_with_alphabet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startsWithAlphabet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StartsWithAlphabet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#tags IdentityDomainsPasswordPolicy#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#timeouts IdentityDomainsPasswordPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#user_name_disallowed IdentityDomainsPasswordPolicy#user_name_disallowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userNameDisallowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UserNameDisallowed
            {
                get => GetInstanceProperty<object?>();
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
