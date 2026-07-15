using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec oci_database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec oci_database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec))!;

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseObjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseObjectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseObjectType
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Operations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Roles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securitySchemes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecuritySchemes
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoApiSpecKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoApiSpecKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsDatabaseApiGatewayConfigIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoApiSpecKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoApiSpecKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
