using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config cloudflare_hyperdrive_config}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.HyperdriveConfig.HyperdriveConfig), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigConfig\"}}]")]
    public class HyperdriveConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config cloudflare_hyperdrive_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HyperdriveConfig(Constructs.Construct scope, string id, cloudflare.HyperdriveConfig.IHyperdriveConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.HyperdriveConfig.IHyperdriveConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HyperdriveConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HyperdriveConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a HyperdriveConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HyperdriveConfig to import.</param>
        /// <param name="importFromId">The id of the existing HyperdriveConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HyperdriveConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HyperdriveConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HyperdriveConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HyperdriveConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.HyperdriveConfig.HyperdriveConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCaching", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigCaching\"}}]")]
        public virtual void PutCaching(cloudflare.HyperdriveConfig.IHyperdriveConfigCaching @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.HyperdriveConfig.IHyperdriveConfigCaching)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMtls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigMtls\"}}]")]
        public virtual void PutMtls(cloudflare.HyperdriveConfig.IHyperdriveConfigMtls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.HyperdriveConfig.IHyperdriveConfigMtls)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrigin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigOrigin\"}}]")]
        public virtual void PutOrigin(cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaching")]
        public virtual void ResetCaching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtls")]
        public virtual void ResetMtls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginConnectionLimit")]
        public virtual void ResetOriginConnectionLimit()
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
        = GetStaticProperty<string>(typeof(cloudflare.HyperdriveConfig.HyperdriveConfig))!;

        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigCachingOutputReference\"}")]
        public virtual cloudflare.HyperdriveConfig.HyperdriveConfigCachingOutputReference Caching
        {
            get => GetInstanceProperty<cloudflare.HyperdriveConfig.HyperdriveConfigCachingOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigMtlsOutputReference\"}")]
        public virtual cloudflare.HyperdriveConfig.HyperdriveConfigMtlsOutputReference Mtls
        {
            get => GetInstanceProperty<cloudflare.HyperdriveConfig.HyperdriveConfigMtlsOutputReference>()!;
        }

        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigOriginOutputReference\"}")]
        public virtual cloudflare.HyperdriveConfig.HyperdriveConfigOriginOutputReference Origin
        {
            get => GetInstanceProperty<cloudflare.HyperdriveConfig.HyperdriveConfigOriginOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigCaching\"}]}}", isOptional: true)]
        public virtual object? CachingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigMtls\"}]}}", isOptional: true)]
        public virtual object? MtlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originConnectionLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OriginConnectionLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigOrigin\"}]}}", isOptional: true)]
        public virtual object? OriginInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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

        [JsiiProperty(name: "originConnectionLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OriginConnectionLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
