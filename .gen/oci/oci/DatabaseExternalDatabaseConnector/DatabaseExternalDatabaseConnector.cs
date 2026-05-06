using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalDatabaseConnector
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector oci_database_external_database_connector}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnector), fullyQualifiedName: "oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConfig\"}}]")]
    public class DatabaseExternalDatabaseConnector : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector oci_database_external_database_connector} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseExternalDatabaseConnector(Constructs.Construct scope, string id, oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExternalDatabaseConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExternalDatabaseConnector(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseExternalDatabaseConnector resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseExternalDatabaseConnector to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseExternalDatabaseConnector that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseExternalDatabaseConnector to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseExternalDatabaseConnector to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseExternalDatabaseConnector that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseExternalDatabaseConnector to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnector), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConnectionCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionCredentials\"}}]")]
        public virtual void PutConnectionCredentials(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionString\"}}]")]
        public virtual void PutConnectionString(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectorType")]
        public virtual void ResetConnectorType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnector))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionCredentialsOutputReference\"}")]
        public virtual oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionCredentialsOutputReference ConnectionCredentials
        {
            get => GetInstanceProperty<oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "connectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionStringOutputReference\"}")]
        public virtual oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionStringOutputReference ConnectionString
        {
            get => GetInstanceProperty<oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionStringOutputReference>()!;
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

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeConnectionStatusLastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConnectionStatusLastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentialsInput", typeJson: "{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionCredentials\"}", isOptional: true)]
        public virtual oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionCredentials? ConnectionCredentialsInput
        {
            get => GetInstanceProperty<oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionString\"}", isOptional: true)]
        public virtual oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionString? ConnectionStringInput
        {
            get => GetInstanceProperty<oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorAgentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectorAgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectorTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "connectorAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorAgentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
