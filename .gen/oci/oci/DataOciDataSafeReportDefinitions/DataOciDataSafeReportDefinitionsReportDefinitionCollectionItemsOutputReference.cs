using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeReportDefinitions
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnFilters", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnFiltersList\"}")]
        public virtual oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnFiltersList ColumnFilters
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnFiltersList>()!;
        }

        [JsiiProperty(name: "columnInfo", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnInfoList\"}")]
        public virtual oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnInfoList ColumnInfo
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnInfoList>()!;
        }

        [JsiiProperty(name: "columnSortings", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnSortingsList\"}")]
        public virtual oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnSortingsList ColumnSortings
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsColumnSortingsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceStandards", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ComplianceStandards
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSource
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

        [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DisplayOrder
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "isSeeded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSeeded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordTimeSpan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordTimeSpan
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportMimeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportMimeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportRowLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScheduledReportRowLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scimFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScimFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsSummaryList\"}")]
        public virtual oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsSummaryList Summary
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItemsSummaryList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinitions.DataOciDataSafeReportDefinitionsReportDefinitionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeReportDefinitions.IDataOciDataSafeReportDefinitionsReportDefinitionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinitions.IDataOciDataSafeReportDefinitionsReportDefinitionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
