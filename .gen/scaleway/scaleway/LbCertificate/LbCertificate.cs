using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate scaleway_lb_certificate}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.LbCertificate.LbCertificate), fullyQualifiedName: "scaleway.lbCertificate.LbCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.lbCertificate.LbCertificateConfig\"}}]")]
    public class LbCertificate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate scaleway_lb_certificate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LbCertificate(Constructs.Construct scope, string id, scaleway.LbCertificate.ILbCertificateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.LbCertificate.ILbCertificateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbCertificate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LbCertificate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LbCertificate to import.</param>
        /// <param name="importFromId">The id of the existing LbCertificate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LbCertificate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LbCertificate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LbCertificate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LbCertificate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.LbCertificate.LbCertificate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbCertificate.LbCertificateCustomCertificate\"}}]")]
        public virtual void PutCustomCertificate(scaleway.LbCertificate.ILbCertificateCustomCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbCertificate.ILbCertificateCustomCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLetsencrypt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbCertificate.LbCertificateLetsencrypt\"}}]")]
        public virtual void PutLetsencrypt(scaleway.LbCertificate.ILbCertificateLetsencrypt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbCertificate.ILbCertificateLetsencrypt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbCertificate.LbCertificateTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.LbCertificate.ILbCertificateTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbCertificate.ILbCertificateTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomCertificate")]
        public virtual void ResetCustomCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLetsencrypt")]
        public virtual void ResetLetsencrypt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(scaleway.LbCertificate.LbCertificate))!;

        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommonName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateCustomCertificateOutputReference\"}")]
        public virtual scaleway.LbCertificate.LbCertificateCustomCertificateOutputReference CustomCertificate
        {
            get => GetInstanceProperty<scaleway.LbCertificate.LbCertificateCustomCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "letsencrypt", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateLetsencryptOutputReference\"}")]
        public virtual scaleway.LbCertificate.LbCertificateLetsencryptOutputReference Letsencrypt
        {
            get => GetInstanceProperty<scaleway.LbCertificate.LbCertificateLetsencryptOutputReference>()!;
        }

        [JsiiProperty(name: "notValidAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotValidAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notValidBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotValidBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectAlternativeName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubjectAlternativeName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateTimeoutsOutputReference\"}")]
        public virtual scaleway.LbCertificate.LbCertificateTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.LbCertificate.LbCertificateTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customCertificateInput", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateCustomCertificate\"}", isOptional: true)]
        public virtual scaleway.LbCertificate.ILbCertificateCustomCertificate? CustomCertificateInput
        {
            get => GetInstanceProperty<scaleway.LbCertificate.ILbCertificateCustomCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lbIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LbIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "letsencryptInput", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateLetsencrypt\"}", isOptional: true)]
        public virtual scaleway.LbCertificate.ILbCertificateLetsencrypt? LetsencryptInput
        {
            get => GetInstanceProperty<scaleway.LbCertificate.ILbCertificateLetsencrypt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.lbCertificate.LbCertificateTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbId
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
    }
}
