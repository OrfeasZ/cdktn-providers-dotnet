using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationJob
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationJob.DatabaseMigrationJobProgressPhasesOutputReference), fullyQualifiedName: "oci.databaseMigrationJob.DatabaseMigrationJobProgressPhasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseMigrationJobProgressPhasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseMigrationJobProgressPhasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseMigrationJobProgressPhasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationJobProgressPhasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "durationInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "editableParameterFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EditableParameterFiles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationJob.DatabaseMigrationJobProgressPhasesExtractList\"}")]
        public virtual oci.DatabaseMigrationJob.DatabaseMigrationJobProgressPhasesExtractList Extract
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJob.DatabaseMigrationJobProgressPhasesExtractList>()!;
        }

        [JsiiProperty(name: "isAdvisorReportAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAdvisorReportAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSuspendAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSuspendAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logLocation", typeJson: "{\"fqn\":\"oci.databaseMigrationJob.DatabaseMigrationJobProgressPhasesLogLocationList\"}")]
        public virtual oci.DatabaseMigrationJob.DatabaseMigrationJobProgressPhasesLogLocationList LogLocation
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJob.DatabaseMigrationJobProgressPhasesLogLocationList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "progress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Progress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationJob.DatabaseMigrationJobProgressPhases\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationJob.IDatabaseMigrationJobProgressPhases? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationJob.IDatabaseMigrationJobProgressPhases?>();
            set => SetInstanceProperty(value);
        }
    }
}
