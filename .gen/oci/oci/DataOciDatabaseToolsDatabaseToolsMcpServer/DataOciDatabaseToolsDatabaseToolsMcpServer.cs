using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsMcpServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_database_tools_mcp_server oci_database_tools_database_tools_mcp_server}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServer), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerConfig\"}}]")]
    public class DataOciDatabaseToolsDatabaseToolsMcpServer : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_database_tools_mcp_server oci_database_tools_database_tools_mcp_server} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsDatabaseToolsMcpServer(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsDatabaseToolsMcpServer.IDataOciDatabaseToolsDatabaseToolsMcpServerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsDatabaseToolsMcpServer.IDataOciDatabaseToolsDatabaseToolsMcpServerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsDatabaseToolsMcpServer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsDatabaseToolsMcpServer to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsDatabaseToolsMcpServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsDatabaseToolsMcpServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsDatabaseToolsMcpServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_database_tools_mcp_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsDatabaseToolsMcpServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsDatabaseToolsMcpServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServer))!;

        [JsiiProperty(name: "accessTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessTokenExpiryInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "builtInRoles", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerBuiltInRolesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerBuiltInRolesList BuiltInRoles
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerBuiltInRolesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customRoles", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerCustomRolesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerCustomRolesList CustomRoles
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerCustomRolesList>()!;
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
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

        [JsiiProperty(name: "domainAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainAppId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerEndpointsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerEndpointsList>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerLocksList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerLocksList>()!;
        }

        [JsiiProperty(name: "refreshTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTokenExpiryInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerRelatedResourceList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerRelatedResourceList RelatedResource
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerRelatedResourceList>()!;
        }

        [JsiiProperty(name: "runtimeIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeIdentity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerStorageList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerStorageList Storage
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServer.DataOciDatabaseToolsDatabaseToolsMcpServerStorageList>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsMcpServerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsMcpServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseToolsMcpServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsMcpServerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
