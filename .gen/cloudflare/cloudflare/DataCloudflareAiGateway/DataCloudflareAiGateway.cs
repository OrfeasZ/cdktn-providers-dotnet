using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway cloudflare_ai_gateway}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGateway.DataCloudflareAiGateway), fullyQualifiedName: "cloudflare.dataCloudflareAiGateway.DataCloudflareAiGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayConfig\"}}]")]
    public class DataCloudflareAiGateway : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway cloudflare_ai_gateway} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareAiGateway(Constructs.Construct scope, string id, cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareAiGateway resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareAiGateway to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareAiGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareAiGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareAiGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareAiGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareAiGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareAiGateway.DataCloudflareAiGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareAiGateway.DataCloudflareAiGateway))!;

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Authentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cacheInvalidateOnUpdate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CacheInvalidateOnUpdate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "collectLogs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CollectLogs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dlp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayDlpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayDlpOutputReference Dlp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayDlpOutputReference>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayFilterOutputReference>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logManagement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogManagement
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "logManagementStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogManagementStrategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logpushPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogpushPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "otel", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayOtelList\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayOtelList Otel
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayOtelList>()!;
        }

        [JsiiProperty(name: "rateLimitingInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateLimitingInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rateLimitingLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateLimitingLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rateLimitingTechnique", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateLimitingTechnique
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retryBackoff", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetryBackoff
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retryMaxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryMaxAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stripe", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayStripeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayStripeOutputReference Stripe
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayStripeOutputReference>()!;
        }

        [JsiiProperty(name: "workersAiBillingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkersAiBillingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zdr", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Zdr
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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
    }
}
