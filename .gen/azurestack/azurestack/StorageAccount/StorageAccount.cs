using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.StorageAccount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/storage_account azurestack_storage_account}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.StorageAccount.StorageAccount), fullyQualifiedName: "azurestack.storageAccount.StorageAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.storageAccount.StorageAccountConfig\"}}]")]
    public class StorageAccount : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/storage_account azurestack_storage_account} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageAccount(Constructs.Construct scope, string id, azurestack.StorageAccount.IStorageAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.StorageAccount.IStorageAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StorageAccount resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageAccount to import.</param>
        /// <param name="importFromId">The id of the existing StorageAccount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageAccount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageAccount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/storage_account#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageAccount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageAccount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.StorageAccount.StorageAccount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.storageAccount.StorageAccountCustomDomain\"}}]")]
        public virtual void PutCustomDomain(azurestack.StorageAccount.IStorageAccountCustomDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.StorageAccount.IStorageAccountCustomDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.storageAccount.StorageAccountTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.StorageAccount.IStorageAccountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.StorageAccount.IStorageAccountTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountEncryptionSource")]
        public virtual void ResetAccountEncryptionSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKind")]
        public virtual void ResetAccountKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomDomain")]
        public virtual void ResetCustomDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableBlobEncryption")]
        public virtual void ResetEnableBlobEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableHttpsTrafficOnly")]
        public virtual void ResetEnableHttpsTrafficOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurestack.StorageAccount.StorageAccount))!;

        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurestack.storageAccount.StorageAccountCustomDomainOutputReference\"}")]
        public virtual azurestack.StorageAccount.StorageAccountCustomDomainOutputReference CustomDomain
        {
            get => GetInstanceProperty<azurestack.StorageAccount.StorageAccountCustomDomainOutputReference>()!;
        }

        [JsiiProperty(name: "primaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryQueueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryQueueEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryTableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryTableEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryQueueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryQueueEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryTableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryTableEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.storageAccount.StorageAccountTimeoutsOutputReference\"}")]
        public virtual azurestack.StorageAccount.StorageAccountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.StorageAccount.StorageAccountTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountEncryptionSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountEncryptionSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountReplicationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountReplicationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDomainInput", typeJson: "{\"fqn\":\"azurestack.storageAccount.StorageAccountCustomDomain\"}", isOptional: true)]
        public virtual azurestack.StorageAccount.IStorageAccountCustomDomain? CustomDomainInput
        {
            get => GetInstanceProperty<azurestack.StorageAccount.IStorageAccountCustomDomain?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableBlobEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableBlobEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableHttpsTrafficOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableHttpsTrafficOnlyInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.StorageAccount.IStorageAccountTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.storageAccount.StorageAccountTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountEncryptionSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountEncryptionSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountReplicationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableBlobEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableBlobEncryption
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableHttpsTrafficOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableHttpsTrafficOnly
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
