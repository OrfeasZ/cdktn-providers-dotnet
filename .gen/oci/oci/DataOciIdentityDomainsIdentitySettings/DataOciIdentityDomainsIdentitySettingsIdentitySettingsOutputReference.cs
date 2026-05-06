using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentitySettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentitySettingsIdentitySettingsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emitLockedMessageWhenUserIsLocked", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmitLockedMessageWhenUserIsLocked
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "identitySettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentitySettingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMetaList>()!;
        }

        [JsiiProperty(name: "myProfile", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMyProfileList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMyProfileList MyProfile
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsMyProfileList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "posixGid", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixGidList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixGidList PosixGid
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixGidList>()!;
        }

        [JsiiProperty(name: "posixUid", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixUidList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixUidList PosixUid
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsPosixUidList>()!;
        }

        [JsiiProperty(name: "primaryEmailRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PrimaryEmailRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "removeInvalidEmails", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoveInvalidEmails
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "returnInactiveOverLockedMessage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReturnInactiveOverLockedMessage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTokensList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTokensList Tokens
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettingsTokensList>()!;
        }

        [JsiiProperty(name: "userAllowedToSetRecoveryEmail", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UserAllowedToSetRecoveryEmail
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentitySettings.DataOciIdentityDomainsIdentitySettingsIdentitySettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentitySettings.IDataOciIdentityDomainsIdentitySettingsIdentitySettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentitySettings.IDataOciIdentityDomainsIdentitySettingsIdentitySettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
