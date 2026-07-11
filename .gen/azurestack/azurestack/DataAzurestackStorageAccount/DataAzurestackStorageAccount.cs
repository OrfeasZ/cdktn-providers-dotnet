using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackStorageAccount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_account azurestack_storage_account}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccount), fullyQualifiedName: "azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountConfig\"}}]")]
    public class DataAzurestackStorageAccount : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_account azurestack_storage_account} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurestackStorageAccount(Constructs.Construct scope, string id, azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurestackStorageAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurestackStorageAccount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurestackStorageAccount resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurestackStorageAccount to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurestackStorageAccount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurestackStorageAccount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurestackStorageAccount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_account#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurestackStorageAccount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurestackStorageAccount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccount))!;

        [JsiiProperty(name: "accountEncryptionSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountEncryptionSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountReplicationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountCustomDomainList\"}")]
        public virtual azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccountCustomDomainList CustomDomain
        {
            get => GetInstanceProperty<azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccountCustomDomainList>()!;
        }

        [JsiiProperty(name: "enableBlobEncryption", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableBlobEncryption
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "httpsTrafficOnlyEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HttpsTrafficOnlyEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountTimeoutsOutputReference\"}")]
        public virtual azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.DataAzurestackStorageAccount.DataAzurestackStorageAccountTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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
    }
}
