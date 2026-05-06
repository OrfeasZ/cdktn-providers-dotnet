using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationMigration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_migration_migration oci_database_migration_migration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigration), fullyQualifiedName: "oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationConfig\"}}]")]
    public class DataOciDatabaseMigrationMigration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_migration_migration oci_database_migration_migration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMigrationMigration(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationMigration.IDataOciDatabaseMigrationMigrationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationMigration.IDataOciDatabaseMigrationMigrationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMigrationMigration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMigrationMigration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMigrationMigration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMigrationMigration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMigrationMigration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_migration_migration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMigrationMigration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMigrationMigration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigration))!;

        [JsiiProperty(name: "advancedParameters", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvancedParametersList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvancedParametersList AdvancedParameters
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvancedParametersList>()!;
        }

        [JsiiProperty(name: "advisorSettings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvisorSettingsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvisorSettingsList AdvisorSettings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationAdvisorSettingsList>()!;
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

        [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseCombination
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataTransferMediumDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationDataTransferMediumDetailsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationDataTransferMediumDetailsList DataTransferMediumDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationDataTransferMediumDetailsList>()!;
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

        [JsiiProperty(name: "excludeObjects", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationExcludeObjectsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationExcludeObjectsList ExcludeObjects
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationExcludeObjectsList>()!;
        }

        [JsiiProperty(name: "executingJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutingJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "ggsDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationGgsDetailsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationGgsDetailsList GgsDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationGgsDetailsList>()!;
        }

        [JsiiProperty(name: "hubDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationHubDetailsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationHubDetailsList HubDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationHubDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeObjects", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationIncludeObjectsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationIncludeObjectsList IncludeObjects
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationIncludeObjectsList>()!;
        }

        [JsiiProperty(name: "initialLoadSettings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsList InitialLoadSettings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceContainerDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceContainerDatabaseConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabaseConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceStandbyDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceStandbyDatabaseConnectionId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "targetDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDatabaseConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastMigration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastMigration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "migrationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MigrationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "migrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
