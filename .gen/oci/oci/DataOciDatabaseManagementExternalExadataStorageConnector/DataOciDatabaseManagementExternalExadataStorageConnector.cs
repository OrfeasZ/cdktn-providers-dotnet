using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalExadataStorageConnector
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_external_exadata_storage_connector oci_database_management_external_exadata_storage_connector}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnector), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnectorConfig\"}}]")]
    public class DataOciDatabaseManagementExternalExadataStorageConnector : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_external_exadata_storage_connector oci_database_management_external_exadata_storage_connector} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementExternalExadataStorageConnector(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementExternalExadataStorageConnector.IDataOciDatabaseManagementExternalExadataStorageConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementExternalExadataStorageConnector.IDataOciDatabaseManagementExternalExadataStorageConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalExadataStorageConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalExadataStorageConnector(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementExternalExadataStorageConnector resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementExternalExadataStorageConnector to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementExternalExadataStorageConnector that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementExternalExadataStorageConnector to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementExternalExadataStorageConnector to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_external_exadata_storage_connector#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementExternalExadataStorageConnector that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementExternalExadataStorageConnector to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnector), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnector))!;

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialInfo", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnectorCredentialInfoList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnectorCredentialInfoList CredentialInfo
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalExadataStorageConnector.DataOciDatabaseManagementExternalExadataStorageConnectorCredentialInfoList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "internalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerId
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalExadataStorageConnectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalExadataStorageConnectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "externalExadataStorageConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalExadataStorageConnectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
