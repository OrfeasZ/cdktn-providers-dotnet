using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationJobAdvisorReportChecks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsColumnsList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsColumnsList Columns
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsColumnsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fixupScriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixupScriptLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "impact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Impact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isExclusionAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsExclusionAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReviewed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReviewed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsMetadataList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsMetadataList>()!;
        }

        [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resultType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResultType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.IDataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.IDataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
