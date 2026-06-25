using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessmentAssessors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsActionsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsActionsList Actions
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsActionsList>()!;
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessorGroup", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsAssessorGroupList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsAssessorGroupList AssessorGroup
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItemsAssessorGroupList>()!;
        }

        [JsiiProperty(name: "assessorResult", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorResult
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksSummary
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "doesScriptRequireRestart", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DoesScriptRequireRestart
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hasScript", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasScript
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "script", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Script
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessors.DataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessors.IDataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessors.IDataOciDatabaseMigrationAssessmentAssessorsAssessorSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
