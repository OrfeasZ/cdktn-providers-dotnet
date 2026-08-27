using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_global oci_database_tools_runtime_database_tools_database_api_gateway_config_global}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_global oci_database_tools_runtime_database_tools_database_api_gateway_config_global} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_global#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal))!;

        [JsiiProperty(name: "advancedProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdvancedProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "certificateBundle", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleList\"}")]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleList CertificateBundle
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleList>()!;
        }

        [JsiiProperty(name: "databaseApiStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseApiStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentRoot
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpsPort
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "metadataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "poolRoute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRoute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "poolRoutingHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRoutingHeader
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
        [JsiiProperty(name: "globalKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GlobalKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
