using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool oci_database_tools_runtime_database_tools_database_api_gateway_config_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool oci_database_tools_runtime_database_tools_database_api_gateway_config_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool))!;

        [JsiiProperty(name: "advancedProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdvancedProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "databaseActionsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseActionsStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
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

        [JsiiProperty(name: "initialPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jwtProfileAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileAudience
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileIssuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileIssuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileJwkUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileJwkUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileRoleClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileRoleClaimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "poolRouteValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRouteValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restEnabledSqlStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestEnabledSqlStatus
        {
            get => GetInstanceProperty<string>()!;
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
