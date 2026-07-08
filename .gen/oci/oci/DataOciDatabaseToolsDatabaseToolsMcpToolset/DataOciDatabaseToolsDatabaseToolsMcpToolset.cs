using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsMcpToolset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/database_tools_database_tools_mcp_toolset oci_database_tools_database_tools_mcp_toolset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolset), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetConfig\"}}]")]
    public class DataOciDatabaseToolsDatabaseToolsMcpToolset : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/database_tools_database_tools_mcp_toolset oci_database_tools_database_tools_mcp_toolset} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsDatabaseToolsMcpToolset(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.IDataOciDatabaseToolsDatabaseToolsMcpToolsetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.IDataOciDatabaseToolsDatabaseToolsMcpToolsetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpToolset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpToolset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsDatabaseToolsMcpToolset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsDatabaseToolsMcpToolset to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsDatabaseToolsMcpToolset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsDatabaseToolsMcpToolset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsDatabaseToolsMcpToolset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/database_tools_database_tools_mcp_toolset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsDatabaseToolsMcpToolset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsDatabaseToolsMcpToolset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolset))!;

        [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedRoles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseToolsMcpServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsMcpServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultExecutionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultExecutionType
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "generativeAiSemanticStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerativeAiSemanticStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetLocksList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetLocksList>()!;
        }

        [JsiiProperty(name: "reports", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetReportsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetReportsList Reports
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetReportsList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetSourceList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetSourceList>()!;
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

        [JsiiProperty(name: "toolDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "toolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tools", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetToolsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetToolsList Tools
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetToolsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetVariablesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetVariablesList Variables
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolset.DataOciDatabaseToolsDatabaseToolsMcpToolsetVariablesList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsMcpToolsetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsMcpToolsetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseToolsMcpToolsetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsMcpToolsetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
