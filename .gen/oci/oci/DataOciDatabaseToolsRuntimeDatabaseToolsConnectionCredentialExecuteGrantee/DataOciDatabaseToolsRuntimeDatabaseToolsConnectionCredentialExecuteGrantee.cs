using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_execute_grantee oci_database_tools_runtime_database_tools_connection_credential_execute_grantee}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_execute_grantee oci_database_tools_runtime_database_tools_connection_credential_execute_grantee} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_execute_grantee#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee))!;

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

        [JsiiOptional]
        [JsiiProperty(name: "credentialKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeGranteeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecuteGranteeKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executeGranteeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecuteGranteeKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
