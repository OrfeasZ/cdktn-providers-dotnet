using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsPasswordPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_password_policy oci_identity_domains_password_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicy), fullyQualifiedName: "oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyConfig\"}}]")]
    public class DataOciIdentityDomainsPasswordPolicy : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_password_policy oci_identity_domains_password_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsPasswordPolicy(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsPasswordPolicy.IDataOciIdentityDomainsPasswordPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsPasswordPolicy.IDataOciIdentityDomainsPasswordPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsPasswordPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsPasswordPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsPasswordPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsPasswordPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsPasswordPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsPasswordPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsPasswordPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_password_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsPasswordPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsPasswordPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicy))!;

        [JsiiProperty(name: "allowedChars", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedChars
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuredPasswordPolicyRules", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyConfiguredPasswordPolicyRulesList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyConfiguredPasswordPolicyRulesList ConfiguredPasswordPolicyRules
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyConfiguredPasswordPolicyRulesList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dictionaryDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DictionaryDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dictionaryLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DictionaryLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dictionaryWordDisallowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DictionaryWordDisallowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "disallowedChars", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisallowedChars
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disallowedSubstrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DisallowedSubstrings
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "disallowedUserAttributeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DisallowedUserAttributeValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "distinctCharacters", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DistinctCharacters
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstNameDisallowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FirstNameDisallowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "forcePasswordReset", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForcePasswordReset
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyGroupsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lastNameDisallowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LastNameDisallowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lockoutDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LockoutDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxIncorrectAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIncorrectAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRepeatedChars", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRepeatedChars
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSpecialChars", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSpecialChars
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyMetaList>()!;
        }

        [JsiiProperty(name: "minAlphaNumerals", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAlphaNumerals
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minAlphas", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAlphas
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minLowerCase", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinLowerCase
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minNumerals", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinNumerals
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minPasswordAge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPasswordAge
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSpecialChars", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSpecialChars
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minUniqueChars", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinUniqueChars
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minUpperCase", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinUpperCase
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numPasswordsInHistory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumPasswordsInHistory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordExpiresAfter", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordExpiresAfter
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "passwordExpireWarning", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordExpireWarning
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "passwordStrength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordStrength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requiredChars", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequiredChars
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "startsWithAlphabet", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable StartsWithAlphabet
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicy.DataOciIdentityDomainsPasswordPolicyTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userNameDisallowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UserNameDisallowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
