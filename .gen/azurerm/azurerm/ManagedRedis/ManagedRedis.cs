using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/managed_redis azurerm_managed_redis}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ManagedRedis.ManagedRedis), fullyQualifiedName: "azurerm.managedRedis.ManagedRedis", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisConfig\"}}]")]
    public class ManagedRedis : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/managed_redis azurerm_managed_redis} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ManagedRedis(Constructs.Construct scope, string id, azurerm.ManagedRedis.IManagedRedisConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ManagedRedis.IManagedRedisConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedRedis(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedRedis(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ManagedRedis resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ManagedRedis to import.</param>
        /// <param name="importFromId">The id of the existing ManagedRedis that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ManagedRedis to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ManagedRedis to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/managed_redis#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ManagedRedis that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ManagedRedis to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ManagedRedis.ManagedRedis), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomerManagedKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisCustomerManagedKey\"}}]")]
        public virtual void PutCustomerManagedKey(azurerm.ManagedRedis.IManagedRedisCustomerManagedKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedRedis.IManagedRedisCustomerManagedKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabase\"}}]")]
        public virtual void PutDefaultDatabase(azurerm.ManagedRedis.IManagedRedisDefaultDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedRedis.IManagedRedisDefaultDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ManagedRedis.IManagedRedisIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedRedis.IManagedRedisIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ManagedRedis.IManagedRedisTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedRedis.IManagedRedisTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomerManagedKey")]
        public virtual void ResetCustomerManagedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultDatabase")]
        public virtual void ResetDefaultDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHighAvailabilityEnabled")]
        public virtual void ResetHighAvailabilityEnabled()
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
        = GetStaticProperty<string>(typeof(azurerm.ManagedRedis.ManagedRedis))!;

        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisCustomerManagedKeyOutputReference\"}")]
        public virtual azurerm.ManagedRedis.ManagedRedisCustomerManagedKeyOutputReference CustomerManagedKey
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.ManagedRedisCustomerManagedKeyOutputReference>()!;
        }

        [JsiiProperty(name: "defaultDatabase", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseOutputReference\"}")]
        public virtual azurerm.ManagedRedis.ManagedRedisDefaultDatabaseOutputReference DefaultDatabase
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.ManagedRedisDefaultDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisIdentityOutputReference\"}")]
        public virtual azurerm.ManagedRedis.ManagedRedisIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.ManagedRedisIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisTimeoutsOutputReference\"}")]
        public virtual azurerm.ManagedRedis.ManagedRedisTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.ManagedRedisTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedKeyInput", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisCustomerManagedKey\"}", isOptional: true)]
        public virtual azurerm.ManagedRedis.IManagedRedisCustomerManagedKey? CustomerManagedKeyInput
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.IManagedRedisCustomerManagedKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultDatabaseInput", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabase\"}", isOptional: true)]
        public virtual azurerm.ManagedRedis.IManagedRedisDefaultDatabase? DefaultDatabaseInput
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.IManagedRedisDefaultDatabase?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "highAvailabilityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HighAvailabilityEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisIdentity\"}", isOptional: true)]
        public virtual azurerm.ManagedRedis.IManagedRedisIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.IManagedRedisIdentity?>();
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
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ManagedRedis.IManagedRedisTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.managedRedis.ManagedRedisTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "highAvailabilityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object HighAvailabilityEnabled
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

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
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
