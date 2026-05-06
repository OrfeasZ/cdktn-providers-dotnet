using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementProvisions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementProvisionsProvisionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemListingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemListingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployedResources", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsDeployedResourcesList\"}")]
        public virtual oci.DataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsDeployedResourcesList DeployedResources
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsDeployedResourcesList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
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

        [JsiiProperty(name: "packageCatalogItemDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemListingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemListingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisionDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rmsApplyJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RmsApplyJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tfOutputs", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsTfOutputsList\"}")]
        public virtual oci.DataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsTfOutputsList TfOutputs
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItemsTfOutputsList>()!;
        }

        [JsiiProperty(name: "tfVariableCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableCurrentUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableCurrentUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableRegionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableRegionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableTenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableTenancyId
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvisions.DataOciFleetAppsManagementProvisionsProvisionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementProvisions.IDataOciFleetAppsManagementProvisionsProvisionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvisions.IDataOciFleetAppsManagementProvisionsProvisionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
