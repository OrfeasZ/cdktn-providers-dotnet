using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment oci_database_migration_assessment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessment), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentConfig\"}}]")]
    public class DataOciDatabaseMigrationAssessment : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment oci_database_migration_assessment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMigrationAssessment(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationAssessment.IDataOciDatabaseMigrationAssessmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationAssessment.IDataOciDatabaseMigrationAssessmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMigrationAssessment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMigrationAssessment to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMigrationAssessment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMigrationAssessment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMigrationAssessment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMigrationAssessment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMigrationAssessment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessment))!;

        [JsiiProperty(name: "acceptableDowntime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptableDowntime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessmentMigrationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentMigrationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bulkIncludeExcludeData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BulkIncludeExcludeData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseCombination
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseDataSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseDataSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ddlExpectation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DdlExpectation
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

        [JsiiProperty(name: "excludeObjects", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentExcludeObjectsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentExcludeObjectsList ExcludeObjects
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentExcludeObjectsList>()!;
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

        [JsiiProperty(name: "includeObjects", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentIncludeObjectsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentIncludeObjectsList IncludeObjects
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentIncludeObjectsList>()!;
        }

        [JsiiProperty(name: "isCdbSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCdbSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "migrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSpeedMegabitPerSecond", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkSpeedMegabitPerSecond
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabaseConnection", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentSourceDatabaseConnectionList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentSourceDatabaseConnectionList SourceDatabaseConnection
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentSourceDatabaseConnectionList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDatabaseConnection", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentTargetDatabaseConnectionList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentTargetDatabaseConnectionList TargetDatabaseConnection
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessment.DataOciDatabaseMigrationAssessmentTargetDatabaseConnectionList>()!;
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
        [JsiiProperty(name: "assessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
