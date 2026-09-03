using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster azurerm_mongo_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MongoCluster.MongoCluster), fullyQualifiedName: "azurerm.mongoCluster.MongoCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mongoCluster.MongoClusterConfig\"}}]")]
    public class MongoCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster azurerm_mongo_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MongoCluster(Constructs.Construct scope, string id, azurerm.MongoCluster.IMongoClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MongoCluster.IMongoClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MongoCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MongoCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MongoCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MongoCluster to import.</param>
        /// <param name="importFromId">The id of the existing MongoCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MongoCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MongoCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MongoCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MongoCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.MongoCluster.MongoCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomerManagedKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mongoCluster.MongoClusterCustomerManagedKey\"}}]")]
        public virtual void PutCustomerManagedKey(azurerm.MongoCluster.IMongoClusterCustomerManagedKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MongoCluster.IMongoClusterCustomerManagedKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mongoCluster.MongoClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MongoCluster.IMongoClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MongoCluster.IMongoClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mongoCluster.MongoClusterRestore\"}}]")]
        public virtual void PutRestore(azurerm.MongoCluster.IMongoClusterRestore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MongoCluster.IMongoClusterRestore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mongoCluster.MongoClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MongoCluster.IMongoClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MongoCluster.IMongoClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdministratorPassword")]
        public virtual void ResetAdministratorPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdministratorUsername")]
        public virtual void ResetAdministratorUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthenticationMethods")]
        public virtual void ResetAuthenticationMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeTier")]
        public virtual void ResetComputeTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateMode")]
        public virtual void ResetCreateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerManagedKey")]
        public virtual void ResetCustomerManagedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataApiModeEnabled")]
        public virtual void ResetDataApiModeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHighAvailabilityMode")]
        public virtual void ResetHighAvailabilityMode()
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

        [JsiiMethod(name: "resetPreviewFeatures")]
        public virtual void ResetPreviewFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccess")]
        public virtual void ResetPublicNetworkAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestore")]
        public virtual void ResetRestore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShardCount")]
        public virtual void ResetShardCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceLocation")]
        public virtual void ResetSourceLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceServerId")]
        public virtual void ResetSourceServerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageSizeInGb")]
        public virtual void ResetStorageSizeInGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageType")]
        public virtual void ResetStorageType()
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

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(azurerm.MongoCluster.MongoCluster))!;

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterConnectionStringsList\"}")]
        public virtual azurerm.MongoCluster.MongoClusterConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<azurerm.MongoCluster.MongoClusterConnectionStringsList>()!;
        }

        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterCustomerManagedKeyOutputReference\"}")]
        public virtual azurerm.MongoCluster.MongoClusterCustomerManagedKeyOutputReference CustomerManagedKey
        {
            get => GetInstanceProperty<azurerm.MongoCluster.MongoClusterCustomerManagedKeyOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterIdentityOutputReference\"}")]
        public virtual azurerm.MongoCluster.MongoClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MongoCluster.MongoClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "restore", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterRestoreOutputReference\"}")]
        public virtual azurerm.MongoCluster.MongoClusterRestoreOutputReference Restore
        {
            get => GetInstanceProperty<azurerm.MongoCluster.MongoClusterRestoreOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.MongoCluster.MongoClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MongoCluster.MongoClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationMethodsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AuthenticationMethodsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedKeyInput", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterCustomerManagedKey\"}", isOptional: true)]
        public virtual azurerm.MongoCluster.IMongoClusterCustomerManagedKey? CustomerManagedKeyInput
        {
            get => GetInstanceProperty<azurerm.MongoCluster.IMongoClusterCustomerManagedKey?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataApiModeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DataApiModeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "highAvailabilityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HighAvailabilityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.MongoCluster.IMongoClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MongoCluster.IMongoClusterIdentity?>();
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
        [JsiiProperty(name: "previewFeaturesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreviewFeaturesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicNetworkAccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreInput", typeJson: "{\"fqn\":\"azurerm.mongoCluster.MongoClusterRestore\"}", isOptional: true)]
        public virtual azurerm.MongoCluster.IMongoClusterRestore? RestoreInput
        {
            get => GetInstanceProperty<azurerm.MongoCluster.IMongoClusterRestore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shardCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ShardCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceServerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageTypeInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.MongoCluster.IMongoClusterTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.mongoCluster.MongoClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "administratorPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "administratorUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthenticationMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "dataApiModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DataApiModeEnabled
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

        [JsiiProperty(name: "highAvailabilityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HighAvailabilityMode
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

        [JsiiProperty(name: "previewFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreviewFeatures
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "shardCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShardCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceServerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
