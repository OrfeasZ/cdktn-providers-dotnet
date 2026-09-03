using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountStaticWebsite
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_static_website azurerm_storage_account_static_website}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StorageAccountStaticWebsite.StorageAccountStaticWebsite), fullyQualifiedName: "azurerm.storageAccountStaticWebsite.StorageAccountStaticWebsite", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.storageAccountStaticWebsite.StorageAccountStaticWebsiteConfig\"}}]")]
    public class StorageAccountStaticWebsite : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_static_website azurerm_storage_account_static_website} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageAccountStaticWebsite(Constructs.Construct scope, string id, azurerm.StorageAccountStaticWebsite.IStorageAccountStaticWebsiteConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StorageAccountStaticWebsite.IStorageAccountStaticWebsiteConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountStaticWebsite(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountStaticWebsite(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StorageAccountStaticWebsite resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageAccountStaticWebsite to import.</param>
        /// <param name="importFromId">The id of the existing StorageAccountStaticWebsite that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageAccountStaticWebsite to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageAccountStaticWebsite to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_static_website#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageAccountStaticWebsite that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageAccountStaticWebsite to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.StorageAccountStaticWebsite.StorageAccountStaticWebsite), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountStaticWebsite.StorageAccountStaticWebsiteTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StorageAccountStaticWebsite.IStorageAccountStaticWebsiteTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountStaticWebsite.IStorageAccountStaticWebsiteTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetError404Document")]
        public virtual void ResetError404Document()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexDocument")]
        public virtual void ResetIndexDocument()
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
        = GetStaticProperty<string>(typeof(azurerm.StorageAccountStaticWebsite.StorageAccountStaticWebsite))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccountStaticWebsite.StorageAccountStaticWebsiteTimeoutsOutputReference\"}")]
        public virtual azurerm.StorageAccountStaticWebsite.StorageAccountStaticWebsiteTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StorageAccountStaticWebsite.StorageAccountStaticWebsiteTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "error404DocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Error404DocumentInput
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
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.StorageAccountStaticWebsite.IStorageAccountStaticWebsiteTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.storageAccountStaticWebsite.StorageAccountStaticWebsiteTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "error404Document", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Error404Document
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

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
