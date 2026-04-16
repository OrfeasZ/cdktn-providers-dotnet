using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCloudforceOneRequestMessage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_request_message cloudflare_cloudforce_one_request_message}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCloudforceOneRequestMessage.DataCloudflareCloudforceOneRequestMessage), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequestMessage.DataCloudflareCloudforceOneRequestMessage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareCloudforceOneRequestMessage.DataCloudflareCloudforceOneRequestMessageConfig\"}}]")]
    public class DataCloudflareCloudforceOneRequestMessage : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_request_message cloudflare_cloudforce_one_request_message} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareCloudforceOneRequestMessage(Constructs.Construct scope, string id, cloudflare.DataCloudflareCloudforceOneRequestMessage.IDataCloudflareCloudforceOneRequestMessageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareCloudforceOneRequestMessage.IDataCloudflareCloudforceOneRequestMessageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCloudforceOneRequestMessage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCloudforceOneRequestMessage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareCloudforceOneRequestMessage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareCloudforceOneRequestMessage to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareCloudforceOneRequestMessage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareCloudforceOneRequestMessage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareCloudforceOneRequestMessage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_request_message#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareCloudforceOneRequestMessage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareCloudforceOneRequestMessage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareCloudforceOneRequestMessage.DataCloudflareCloudforceOneRequestMessage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAfter")]
        public virtual void ResetAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBefore")]
        public virtual void ResetBefore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortBy")]
        public virtual void ResetSortBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortOrder")]
        public virtual void ResetSortOrder()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareCloudforceOneRequestMessage.DataCloudflareCloudforceOneRequestMessage))!;

        [JsiiProperty(name: "author", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Author
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isFollowOnRequest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFollowOnRequest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "updated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Updated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "afterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "beforeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BeforeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perPageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PerPageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SortByInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortOrderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SortOrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string After
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "before", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Before
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Page
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerPage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortBy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortOrder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
