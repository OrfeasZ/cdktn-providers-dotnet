using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessmentAssessor
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorActionsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "isDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDefinedProperties", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActionsUserDefinedPropertiesList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActionsUserDefinedPropertiesList UserDefinedProperties
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActionsUserDefinedPropertiesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessor.DataOciDatabaseMigrationAssessmentAssessorActions\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessor.IDataOciDatabaseMigrationAssessmentAssessorActions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessor.IDataOciDatabaseMigrationAssessmentAssessorActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
