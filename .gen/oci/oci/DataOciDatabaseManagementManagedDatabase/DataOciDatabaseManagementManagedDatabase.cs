using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database oci_database_management_managed_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabase), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database oci_database_management_managed_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabase(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabase.IDataOciDatabaseManagementManagedDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabase.IDataOciDatabaseManagementManagedDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetDatabasePlatformName")]
        public virtual void ResetDatabasePlatformName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabase))!;

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbmgmtFeatureConfigs", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseDbmgmtFeatureConfigsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseDbmgmtFeatureConfigsList DbmgmtFeatureConfigs
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseDbmgmtFeatureConfigsList>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedDatabaseGroups", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseManagedDatabaseGroupsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseManagedDatabaseGroupsList ManagedDatabaseGroups
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabase.DataOciDatabaseManagementManagedDatabaseManagedDatabaseGroupsList>()!;
        }

        [JsiiProperty(name: "managementOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementOption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentContainerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentContainerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databasePlatformNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabasePlatformNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databasePlatformName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabasePlatformName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
