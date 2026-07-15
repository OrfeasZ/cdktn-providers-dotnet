using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_connection_property_set oci_database_tools_runtime_database_tools_connection_property_set}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_connection_property_set oci_database_tools_runtime_database_tools_connection_property_set} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/database_tools_runtime_database_tools_connection_property_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet))!;

        [JsiiProperty(name: "authenticationSubstitutions", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AuthenticationSubstitutions
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseResourcePrincipalStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderList\"}")]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderList IdentityProvider
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderList>()!;
        }

        [JsiiProperty(name: "instanceDbmsCredentialEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDbmsCredentialEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isMutable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMutable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageBucketCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageBucketCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "prerequisitesCheck", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList\"}")]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList PrerequisitesCheck
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList>()!;
        }

        [JsiiProperty(name: "printServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrintServerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertySetKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropertySetKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propertySetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropertySetKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
