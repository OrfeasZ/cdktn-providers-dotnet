using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessmentAssessorChecks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessorCheckGroup", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsAssessorCheckGroupList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsAssessorCheckGroupList AssessorCheckGroup
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsAssessorCheckGroupList>()!;
        }

        [JsiiProperty(name: "assessorCheckState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorCheckState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checkAction", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionList CheckAction
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionList>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsColumnsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsColumnsList Columns
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsColumnsList>()!;
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

        [JsiiProperty(name: "fixupScriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixupScriptLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helpLinkText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelpLinkText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helpLinkUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelpLinkUrl
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

        [JsiiProperty(name: "logLocation", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsLogLocationList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsLogLocationList LogLocation
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsLogLocationList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectsDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectsDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.IDataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.IDataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
