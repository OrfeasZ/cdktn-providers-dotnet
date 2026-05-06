using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsPasswordPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedChars", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedChars
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuredPasswordPolicyRules", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesConfiguredPasswordPolicyRulesList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesConfiguredPasswordPolicyRulesList ConfiguredPasswordPolicyRules
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesConfiguredPasswordPolicyRulesList>()!;
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

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesGroupsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesMetaList>()!;
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPoliciesTagsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsPasswordPolicies.DataOciIdentityDomainsPasswordPoliciesPasswordPolicies\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsPasswordPolicies.IDataOciIdentityDomainsPasswordPoliciesPasswordPolicies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsPasswordPolicies.IDataOciIdentityDomainsPasswordPoliciesPasswordPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
