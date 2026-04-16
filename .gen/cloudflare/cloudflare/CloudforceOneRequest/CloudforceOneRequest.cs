using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CloudforceOneRequest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/cloudforce_one_request cloudflare_cloudforce_one_request}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.CloudforceOneRequest.CloudforceOneRequest), fullyQualifiedName: "cloudflare.cloudforceOneRequest.CloudforceOneRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.cloudforceOneRequest.CloudforceOneRequestConfig\"}}]")]
    public class CloudforceOneRequest : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/cloudforce_one_request cloudflare_cloudforce_one_request} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudforceOneRequest(Constructs.Construct scope, string id, cloudflare.CloudforceOneRequest.ICloudforceOneRequestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.CloudforceOneRequest.ICloudforceOneRequestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudforceOneRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudforceOneRequest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CloudforceOneRequest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudforceOneRequest to import.</param>
        /// <param name="importFromId">The id of the existing CloudforceOneRequest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudforceOneRequest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudforceOneRequest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/cloudforce_one_request#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudforceOneRequest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudforceOneRequest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.CloudforceOneRequest.CloudforceOneRequest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestType")]
        public virtual void ResetRequestType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSummary")]
        public virtual void ResetSummary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlp")]
        public virtual void ResetTlp()
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
        = GetStaticProperty<string>(typeof(cloudflare.CloudforceOneRequest.CloudforceOneRequest))!;

        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Completed
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

        [JsiiProperty(name: "messageTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessageTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "request", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Request
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tokens
        {
            get => GetInstanceProperty<double>()!;
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
        [JsiiProperty(name: "contentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "summaryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SummaryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tlp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
