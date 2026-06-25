using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementReportMetadata
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "columnMetadata", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsColumnMetadataList\"}")]
        public virtual oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsColumnMetadataList ColumnMetadata
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsColumnMetadataList>()!;
        }

        [JsiiProperty(name: "defaultOrderClause", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsDefaultOrderClauseList\"}")]
        public virtual oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsDefaultOrderClauseList DefaultOrderClause
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsDefaultOrderClauseList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsFiltersList\"}")]
        public virtual oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsFiltersList Filters
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItemsFiltersList>()!;
        }

        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metric
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementReportMetadata.DataOciFleetAppsManagementReportMetadataReportMetadataCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementReportMetadata.IDataOciFleetAppsManagementReportMetadataReportMetadataCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementReportMetadata.IDataOciFleetAppsManagementReportMetadataReportMetadataCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
