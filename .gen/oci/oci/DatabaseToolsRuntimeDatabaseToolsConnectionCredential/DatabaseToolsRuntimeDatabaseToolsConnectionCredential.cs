using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_connection_credential oci_database_tools_runtime_database_tools_connection_credential}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredential), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredential", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialConfig\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionCredential : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_connection_credential oci_database_tools_runtime_database_tools_connection_credential} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseToolsRuntimeDatabaseToolsConnectionCredential(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsConnectionCredential(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsConnectionCredential(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseToolsRuntimeDatabaseToolsConnectionCredential resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsConnectionCredential to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseToolsRuntimeDatabaseToolsConnectionCredential that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsConnectionCredential to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsConnectionCredential to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_connection_credential#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseToolsRuntimeDatabaseToolsConnectionCredential that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsConnectionCredential to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredential), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredential))!;

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Enabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialRelatedResourceList\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialRelatedResourceList RelatedResource
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialRelatedResourceList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "windowsDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowsDomain
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredential.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredential.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
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

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
