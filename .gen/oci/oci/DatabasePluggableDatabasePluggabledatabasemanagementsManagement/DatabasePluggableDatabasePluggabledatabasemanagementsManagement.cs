using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management oci_database_pluggable_database_pluggabledatabasemanagements_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagement), fullyQualifiedName: "oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementConfig\"}}]")]
    public class DatabasePluggableDatabasePluggabledatabasemanagementsManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management oci_database_pluggable_database_pluggabledatabasemanagements_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabasePluggableDatabasePluggabledatabasemanagementsManagement(Constructs.Construct scope, string id, oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePluggableDatabasePluggabledatabasemanagementsManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePluggableDatabasePluggabledatabasemanagementsManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabasePluggableDatabasePluggabledatabasemanagementsManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabasePluggableDatabasePluggabledatabasemanagementsManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabasePluggableDatabasePluggabledatabasemanagementsManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabasePluggableDatabasePluggabledatabasemanagementsManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabasePluggableDatabasePluggabledatabasemanagementsManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabasePluggableDatabasePluggabledatabasemanagementsManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabasePluggableDatabasePluggabledatabasemanagementsManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCredentialDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails\"}}]")]
        public virtual void PutCredentialDetails(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRole")]
        public virtual void ResetRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslSecretId")]
        public virtual void ResetSslSecretId()
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
        = GetStaticProperty<string>(typeof(oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagement))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementConnectionStringsList\"}")]
        public virtual oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementConnectionStringsList>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetailsOutputReference\"}")]
        public virtual oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetailsOutputReference CredentialDetails
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isRestricted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRestricted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PdbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluggableDatabaseManagementConfig", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementPluggableDatabaseManagementConfigList\"}")]
        public virtual oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementPluggableDatabaseManagementConfigList PluggableDatabaseManagementConfig
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementPluggableDatabaseManagementConfigList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialDetailsInput", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails\"}", isOptional: true)]
        public virtual oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails? CredentialDetailsInput
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enablePluggabledatabasemanagementInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnablePluggabledatabasemanagementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluggableDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluggableDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndPointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateEndPointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enablePluggabledatabasemanagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnablePluggabledatabasemanagement
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluggableDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndPointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
