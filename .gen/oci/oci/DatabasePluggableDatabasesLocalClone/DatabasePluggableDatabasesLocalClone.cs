using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasesLocalClone
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone oci_database_pluggable_databases_local_clone}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClone), fullyQualifiedName: "oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClone", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConfig\"}}]")]
    public class DatabasePluggableDatabasesLocalClone : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone oci_database_pluggable_databases_local_clone} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabasePluggableDatabasesLocalClone(Constructs.Construct scope, string id, oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePluggableDatabasesLocalClone(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePluggableDatabasesLocalClone(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabasePluggableDatabasesLocalClone resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabasePluggableDatabasesLocalClone to import.</param>
        /// <param name="importFromId">The id of the existing DatabasePluggableDatabasesLocalClone that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabasePluggableDatabasesLocalClone to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabasePluggableDatabasesLocalClone to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabasePluggableDatabasesLocalClone that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabasePluggableDatabasesLocalClone to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClone), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPdbAdminPassword")]
        public virtual void ResetPdbAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldPdbAdminAccountBeLocked")]
        public virtual void ResetShouldPdbAdminAccountBeLocked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTdeWalletPassword")]
        public virtual void ResetTargetTdeWalletPassword()
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
        = GetStaticProperty<string>(typeof(oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClone))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConnectionStringsList\"}")]
        public virtual oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConnectionStringsList>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "pdbNodeLevelDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePdbNodeLevelDetailsList\"}")]
        public virtual oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePdbNodeLevelDetailsList PdbNodeLevelDetails
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePdbNodeLevelDetailsList>()!;
        }

        [JsiiProperty(name: "pluggableDatabaseManagementConfig", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePluggableDatabaseManagementConfigList\"}")]
        public virtual oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePluggableDatabaseManagementConfigList PluggableDatabaseManagementConfig
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalClonePluggableDatabaseManagementConfigList>()!;
        }

        [JsiiProperty(name: "refreshableCloneConfig", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneRefreshableCloneConfigList\"}")]
        public virtual oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneRefreshableCloneConfigList RefreshableCloneConfig
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneRefreshableCloneConfigList>()!;
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeoutsOutputReference\"}")]
        public virtual oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clonedPdbNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClonedPdbNameInput
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
        [JsiiProperty(name: "pdbAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PdbAdminPasswordInput
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
        [JsiiProperty(name: "shouldPdbAdminAccountBeLockedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldPdbAdminAccountBeLockedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTdeWalletPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetTdeWalletPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clonedPdbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClonedPdbName
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

        [JsiiProperty(name: "pdbAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PdbAdminPassword
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

        [JsiiProperty(name: "shouldPdbAdminAccountBeLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldPdbAdminAccountBeLocked
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

        [JsiiProperty(name: "targetTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetTdeWalletPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
