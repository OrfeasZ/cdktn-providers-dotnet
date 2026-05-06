using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementCatalogItems
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "catalogResultPayload", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogResultPayloadList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogResultPayloadList CatalogResultPayload
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogResultPayloadList>()!;
        }

        [JsiiProperty(name: "catalogSourcePayload", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogSourcePayloadList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogSourcePayloadList CatalogSourcePayload
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItemsCatalogSourcePayloadList>()!;
        }

        [JsiiProperty(name: "cloneCatalogItemTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CloneCatalogItemTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigSourceType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shouldListPublicItems", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldListPublicItems
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "timeBackfillLastChecked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeBackfillLastChecked
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastChecked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastChecked
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeReleased", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReleased
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItems.DataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementCatalogItems.IDataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItems.IDataOciFleetAppsManagementCatalogItemsCatalogItemCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
