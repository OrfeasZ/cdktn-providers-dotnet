using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Provider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs digitalocean}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.Provider.DigitaloceanProvider), fullyQualifiedName: "digitalocean.provider.DigitaloceanProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"digitalocean.provider.DigitaloceanProviderConfig\"}}]")]
    public class DigitaloceanProvider : Io.Cdktn.TerraformProvider
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs digitalocean} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DigitaloceanProvider(Constructs.Construct scope, string id, digitalocean.Provider.IDigitaloceanProviderConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.Provider.IDigitaloceanProviderConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DigitaloceanProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DigitaloceanProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DigitaloceanProvider resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DigitaloceanProvider to import.</param>
        /// <param name="importFromId">The id of the existing DigitaloceanProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DigitaloceanProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DigitaloceanProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DigitaloceanProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DigitaloceanProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.Provider.DigitaloceanProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiEndpoint")]
        public virtual void ResetApiEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRetryMax")]
        public virtual void ResetHttpRetryMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRetryWaitMax")]
        public virtual void ResetHttpRetryWaitMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRetryWaitMin")]
        public virtual void ResetHttpRetryWaitMin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestsPerSecond")]
        public virtual void ResetRequestsPerSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpacesAccessId")]
        public virtual void ResetSpacesAccessId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpacesEndpoint")]
        public virtual void ResetSpacesEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpacesSecretKey")]
        public virtual void ResetSpacesSecretKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToken")]
        public virtual void ResetToken()
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
        = GetStaticProperty<string>(typeof(digitalocean.Provider.DigitaloceanProvider))!;

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryWaitMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMinInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryWaitMinInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestsPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RequestsPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesAccessIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesAccessIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesSecretKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesSecretKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public override string? Alias
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiEndpoint
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryMax
        {
            get => GetInstanceProperty<double?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryWaitMax
        {
            get => GetInstanceProperty<double?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpRetryWaitMin
        {
            get => GetInstanceProperty<double?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RequestsPerSecond
        {
            get => GetInstanceProperty<double?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesAccessId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesAccessId
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesEndpoint
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpacesSecretKey
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Token
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }
    }
}
