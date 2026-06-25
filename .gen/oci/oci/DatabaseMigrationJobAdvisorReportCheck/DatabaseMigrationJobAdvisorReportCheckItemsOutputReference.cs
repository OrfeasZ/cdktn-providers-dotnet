using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationJobAdvisorReportCheck
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsOutputReference), fullyQualifiedName: "oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseMigrationJobAdvisorReportCheckItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseMigrationJobAdvisorReportCheckItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseMigrationJobAdvisorReportCheckItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationJobAdvisorReportCheckItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsColumnsList\"}")]
        public virtual oci.DatabaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsColumnsList Columns
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsColumnsList>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsMetadataList\"}")]
        public virtual oci.DatabaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItemsMetadataList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckItems\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationJobAdvisorReportCheck.IDatabaseMigrationJobAdvisorReportCheckItems? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJobAdvisorReportCheck.IDatabaseMigrationJobAdvisorReportCheckItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
