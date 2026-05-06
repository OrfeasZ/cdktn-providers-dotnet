using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementFleets
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementFleetsFleetCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsCredentialsList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsCredentialsList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsDetailsList Details
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsDetailsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isTargetAutoConfirm", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTargetAutoConfirm
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsNotificationPreferencesList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsNotificationPreferencesList NotificationPreferences
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsNotificationPreferencesList>()!;
        }

        [JsiiProperty(name: "parentFleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentFleetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Products
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsPropertiesList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsPropertiesList Properties
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsPropertiesList>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourcesList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourcesList Resources
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourcesList>()!;
        }

        [JsiiProperty(name: "resourceSelection", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourceSelectionList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourceSelectionList ResourceSelection
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItemsResourceSelectionList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleets.DataOciFleetAppsManagementFleetsFleetCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementFleets.IDataOciFleetAppsManagementFleetsFleetCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleets.IDataOciFleetAppsManagementFleetsFleetCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
