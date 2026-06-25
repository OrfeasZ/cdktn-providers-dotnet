using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessmentAssessorChecks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultValue
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

        [JsiiProperty(name: "isRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOptionsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOptionsList Options
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesPropertiesOptionsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorChecks.DataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesProperties\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorChecks.IDataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorChecks.IDataOciDatabaseMigrationAssessmentAssessorChecksAssessorCheckSummaryCollectionItemsCheckActionUserDefinedPropertiesProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
