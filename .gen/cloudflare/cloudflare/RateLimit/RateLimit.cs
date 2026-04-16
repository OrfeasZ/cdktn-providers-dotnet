using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit cloudflare_rate_limit}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.RateLimit.RateLimit), fullyQualifiedName: "cloudflare.rateLimit.RateLimit", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.rateLimit.RateLimitConfig\"}}]")]
    public class RateLimit : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit cloudflare_rate_limit} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RateLimit(Constructs.Construct scope, string id, cloudflare.RateLimit.IRateLimitConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.RateLimit.IRateLimitConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RateLimit(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RateLimit(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a RateLimit resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the RateLimit to import.</param>
        /// <param name="importFromId">The id of the existing RateLimit that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the RateLimit to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the RateLimit to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing RateLimit that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the RateLimit to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.RateLimit.RateLimit), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.rateLimit.RateLimitAction\"}}]")]
        public virtual void PutAction(cloudflare.RateLimit.IRateLimitAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.RateLimit.IRateLimitAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.rateLimit.RateLimitMatch\"}}]")]
        public virtual void PutMatch(cloudflare.RateLimit.IRateLimitMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.RateLimit.IRateLimitMatch)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(cloudflare.RateLimit.RateLimit))!;

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitActionOutputReference\"}")]
        public virtual cloudflare.RateLimit.RateLimitActionOutputReference Action
        {
            get => GetInstanceProperty<cloudflare.RateLimit.RateLimitActionOutputReference>()!;
        }

        [JsiiProperty(name: "bypass", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitBypassList\"}")]
        public virtual cloudflare.RateLimit.RateLimitBypassList Bypass
        {
            get => GetInstanceProperty<cloudflare.RateLimit.RateLimitBypassList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Disabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchOutputReference\"}")]
        public virtual cloudflare.RateLimit.RateLimitMatchOutputReference Match
        {
            get => GetInstanceProperty<cloudflare.RateLimit.RateLimitMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.rateLimit.RateLimitAction\"}]}}", isOptional: true)]
        public virtual object? ActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.rateLimit.RateLimitMatch\"}]}}", isOptional: true)]
        public virtual object? MatchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "periodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Period
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Threshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
