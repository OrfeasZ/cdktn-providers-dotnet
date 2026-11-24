using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster azurerm_horizondb_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HorizondbCluster.HorizondbCluster), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterConfig\"}}]")]
    public class HorizondbCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster azurerm_horizondb_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HorizondbCluster(Constructs.Construct scope, string id, azurerm.HorizondbCluster.IHorizondbClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HorizondbCluster.IHorizondbClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a HorizondbCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HorizondbCluster to import.</param>
        /// <param name="importFromId">The id of the existing HorizondbCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HorizondbCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HorizondbCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HorizondbCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HorizondbCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.HorizondbCluster.HorizondbCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.HorizondbCluster.IHorizondbClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HorizondbCluster.IHorizondbClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPointInTimeRestore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore\"}}]")]
        public virtual void PutPointInTimeRestore(azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReadWritePool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePool\"}}]")]
        public virtual void PutReadWritePool(azurerm.HorizondbCluster.IHorizondbClusterReadWritePool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HorizondbCluster.IHorizondbClusterReadWritePool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HorizondbCluster.IHorizondbClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HorizondbCluster.IHorizondbClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdministratorPassword")]
        public virtual void ResetAdministratorPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdministratorPasswordWo")]
        public virtual void ResetAdministratorPasswordWo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdministratorPasswordWoVersion")]
        public virtual void ResetAdministratorPasswordWoVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupRetentionInDays")]
        public virtual void ResetBackupRetentionInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoRedundantBackupEnabled")]
        public virtual void ResetGeoRedundantBackupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRestore")]
        public virtual void ResetPointInTimeRestore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresqlVersion")]
        public virtual void ResetPostgresqlVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccess")]
        public virtual void ResetPublicNetworkAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.HorizondbCluster.HorizondbCluster))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterIdentityOutputReference\"}")]
        public virtual azurerm.HorizondbCluster.HorizondbClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.HorizondbClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterPointInTimeRestoreOutputReference\"}")]
        public virtual azurerm.HorizondbCluster.HorizondbClusterPointInTimeRestoreOutputReference PointInTimeRestore
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.HorizondbClusterPointInTimeRestoreOutputReference>()!;
        }

        [JsiiProperty(name: "readWritePool", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolOutputReference\"}")]
        public virtual azurerm.HorizondbCluster.HorizondbClusterReadWritePoolOutputReference ReadWritePool
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.HorizondbClusterReadWritePoolOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.HorizondbCluster.HorizondbClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.HorizondbClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorLoginInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorLoginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorPasswordWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorPasswordWoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorPasswordWoVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdministratorPasswordWoVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupRetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoRedundantBackupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GeoRedundantBackupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRestoreInput", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore? PointInTimeRestoreInput
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresqlVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostgresqlVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicNetworkAccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readWritePoolInput", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePool\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterReadWritePool? ReadWritePoolInput
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterReadWritePool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.HorizondbCluster.IHorizondbClusterTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "administratorLogin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorLogin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "administratorPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "administratorPasswordWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorPasswordWo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "administratorPasswordWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdministratorPasswordWoVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupRetentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "geoRedundantBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object GeoRedundantBackupEnabled
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "postgresqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostgresqlVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicNetworkAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicNetworkAccess
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
