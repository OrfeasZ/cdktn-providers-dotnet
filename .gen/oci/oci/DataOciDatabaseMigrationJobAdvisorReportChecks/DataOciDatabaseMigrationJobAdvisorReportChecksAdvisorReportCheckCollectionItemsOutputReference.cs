using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationJobAdvisorReportChecks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advisorReportCheckId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvisorReportCheckId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isReviewed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReviewed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsItemsList>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsSummaryList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsSummaryList Summary
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItemsSummaryList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobAdvisorReportChecks.DataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationJobAdvisorReportChecks.IDataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobAdvisorReportChecks.IDataOciDatabaseMigrationJobAdvisorReportChecksAdvisorReportCheckCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
