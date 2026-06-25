using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagementDashboardManagementSavedSearches
{
    [JsiiClass(nativeType: typeof(oci.DataOciManagementDashboardManagementSavedSearches.DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciManagementDashboardManagementSavedSearches.DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataConfig
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

        [JsiiProperty(name: "drilldownConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrilldownConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMapMap\"}")]
        public virtual Io.Cdktn.StringMapMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMapMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isOobSavedSearch", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOobSavedSearch
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "metadataVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parametersConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParametersConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "screenImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScreenImage
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uiConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UiConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "widgetTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WidgetTemplate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "widgetVm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WidgetVm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciManagementDashboardManagementSavedSearches.DataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciManagementDashboardManagementSavedSearches.IDataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciManagementDashboardManagementSavedSearches.IDataOciManagementDashboardManagementSavedSearchesManagementSavedSearchCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
