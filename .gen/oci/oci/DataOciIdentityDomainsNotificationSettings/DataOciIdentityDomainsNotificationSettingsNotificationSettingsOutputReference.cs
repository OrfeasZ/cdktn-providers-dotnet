using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsNotificationSettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsNotificationSettingsNotificationSettingsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "eventSettings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsEventSettingsList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsEventSettingsList EventSettings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsEventSettingsList>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsFromEmailAddressList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsFromEmailAddressList FromEmailAddress
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsFromEmailAddressList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsMetaList>()!;
        }

        [JsiiProperty(name: "notificationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable NotificationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "notificationSettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationSettingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
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

        [JsiiProperty(name: "sendNotificationsToSecondaryEmail", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SendNotificationsToSecondaryEmail
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sendNotificationToOldAndNewPrimaryEmailsWhenAdminChangesPrimaryEmail", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SendNotificationToOldAndNewPrimaryEmailsWhenAdminChangesPrimaryEmail
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testModeEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TestModeEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "testRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TestRecipients
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsNotificationSettings.DataOciIdentityDomainsNotificationSettingsNotificationSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsNotificationSettings.IDataOciIdentityDomainsNotificationSettingsNotificationSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsNotificationSettings.IDataOciIdentityDomainsNotificationSettingsNotificationSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
