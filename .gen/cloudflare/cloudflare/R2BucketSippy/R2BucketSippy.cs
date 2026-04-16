using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketSippy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy cloudflare_r2_bucket_sippy}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.R2BucketSippy.R2BucketSippy), fullyQualifiedName: "cloudflare.r2BucketSippy.R2BucketSippy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippyConfig\"}}]")]
    public class R2BucketSippy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy cloudflare_r2_bucket_sippy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public R2BucketSippy(Constructs.Construct scope, string id, cloudflare.R2BucketSippy.IR2BucketSippyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.R2BucketSippy.IR2BucketSippyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketSippy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketSippy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a R2BucketSippy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the R2BucketSippy to import.</param>
        /// <param name="importFromId">The id of the existing R2BucketSippy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the R2BucketSippy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the R2BucketSippy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing R2BucketSippy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the R2BucketSippy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.R2BucketSippy.R2BucketSippy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippyDestination\"}}]")]
        public virtual void PutDestination(cloudflare.R2BucketSippy.IR2BucketSippyDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketSippy.IR2BucketSippyDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippySource\"}}]")]
        public virtual void PutSource(cloudflare.R2BucketSippy.IR2BucketSippySource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketSippy.IR2BucketSippySource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestination")]
        public virtual void ResetDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJurisdiction")]
        public virtual void ResetJurisdiction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
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
        = GetStaticProperty<string>(typeof(cloudflare.R2BucketSippy.R2BucketSippy))!;

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippyDestinationOutputReference\"}")]
        public virtual cloudflare.R2BucketSippy.R2BucketSippyDestinationOutputReference Destination
        {
            get => GetInstanceProperty<cloudflare.R2BucketSippy.R2BucketSippyDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippySourceOutputReference\"}")]
        public virtual cloudflare.R2BucketSippy.R2BucketSippySourceOutputReference Source
        {
            get => GetInstanceProperty<cloudflare.R2BucketSippy.R2BucketSippySourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippyDestination\"}]}}", isOptional: true)]
        public virtual object? DestinationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jurisdictionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JurisdictionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketSippy.R2BucketSippySource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Jurisdiction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
