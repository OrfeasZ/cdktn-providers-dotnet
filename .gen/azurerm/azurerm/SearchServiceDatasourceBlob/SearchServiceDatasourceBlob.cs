using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SearchServiceDatasourceBlob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob azurerm_search_service_datasource_blob}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlob), fullyQualifiedName: "azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobConfig\"}}]")]
    public class SearchServiceDatasourceBlob : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob azurerm_search_service_datasource_blob} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SearchServiceDatasourceBlob(Constructs.Construct scope, string id, azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SearchServiceDatasourceBlob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SearchServiceDatasourceBlob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SearchServiceDatasourceBlob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SearchServiceDatasourceBlob to import.</param>
        /// <param name="importFromId">The id of the existing SearchServiceDatasourceBlob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SearchServiceDatasourceBlob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SearchServiceDatasourceBlob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SearchServiceDatasourceBlob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SearchServiceDatasourceBlob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKey\"}}]")]
        public virtual void PutEncryptionKey(azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerQuery")]
        public virtual void ResetContainerQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKey")]
        public virtual void ResetEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftDeleteColumnName")]
        public virtual void ResetSoftDeleteColumnName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftDeleteMarkerValue")]
        public virtual void ResetSoftDeleteMarkerValue()
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
        = GetStaticProperty<string>(typeof(azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlob))!;

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKeyOutputReference\"}")]
        public virtual azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKeyOutputReference EncryptionKey
        {
            get => GetInstanceProperty<azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeoutsOutputReference\"}")]
        public virtual azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SearchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringWoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringWoVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionStringWoVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey? EncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey?>();
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
        [JsiiProperty(name: "searchServiceEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchServiceEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softDeleteColumnNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftDeleteColumnNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softDeleteMarkerValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftDeleteMarkerValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStringWo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionStringWoVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerQuery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchServiceEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softDeleteColumnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftDeleteColumnName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softDeleteMarkerValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftDeleteMarkerValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
