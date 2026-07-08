using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set oci_database_tools_runtime_database_tools_connection_property_set}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set oci_database_tools_runtime_database_tools_connection_property_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentityProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}}]")]
        public virtual void PutIdentityProvider(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationSubstitutions")]
        public virtual void ResetAuthenticationSubstitutions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutonomousDatabaseResourcePrincipalStatus")]
        public virtual void ResetAutonomousDatabaseResourcePrincipalStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialKey")]
        public virtual void ResetCredentialKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionId")]
        public virtual void ResetFunctionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProvider")]
        public virtual void ResetIdentityProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceDbmsCredentialEnabled")]
        public virtual void ResetInstanceDbmsCredentialEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvokeEndpoint")]
        public virtual void ResetInvokeEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorageBucketCompartmentId")]
        public virtual void ResetObjectStorageBucketCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorageEndpoint")]
        public virtual void ResetObjectStorageEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorageNamespace")]
        public virtual void ResetObjectStorageNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrintServerType")]
        public virtual void ResetPrintServerType()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet))!;

        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference IdentityProvider
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference>()!;
        }

        [JsiiProperty(name: "isMutable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMutable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "prerequisitesCheck", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList PrerequisitesCheck
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetPrerequisitesCheckList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "authenticationSubstitutionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthenticationSubstitutionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousDatabaseResourcePrincipalStatusInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "functionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderInput", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider? IdentityProviderInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceDbmsCredentialEnabledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceDbmsCredentialEnabledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invokeEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvokeEndpointInput
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
        [JsiiProperty(name: "objectStorageBucketCompartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectStorageBucketCompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectStorageEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageNamespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectStorageNamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "printServerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrintServerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertySetKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropertySetKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authenticationSubstitutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AuthenticationSubstitutions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseResourcePrincipalStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionId
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

        [JsiiProperty(name: "instanceDbmsCredentialEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDbmsCredentialEnabled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeEndpoint
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

        [JsiiProperty(name: "objectStorageBucketCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageBucketCompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStorageEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageNamespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "printServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrintServerType
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
