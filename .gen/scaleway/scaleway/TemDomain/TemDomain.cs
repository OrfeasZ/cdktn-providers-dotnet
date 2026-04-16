using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.TemDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/tem_domain scaleway_tem_domain}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.TemDomain.TemDomain), fullyQualifiedName: "scaleway.temDomain.TemDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.temDomain.TemDomainConfig\"}}]")]
    public class TemDomain : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/tem_domain scaleway_tem_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TemDomain(Constructs.Construct scope, string id, scaleway.TemDomain.ITemDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.TemDomain.ITemDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TemDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TemDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a TemDomain resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the TemDomain to import.</param>
        /// <param name="importFromId">The id of the existing TemDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the TemDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the TemDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/tem_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing TemDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the TemDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.TemDomain.TemDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.temDomain.TemDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.TemDomain.ITemDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.TemDomain.ITemDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoconfig")]
        public virtual void ResetAutoconfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.TemDomain.TemDomain))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dkimConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DkimConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dkimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DkimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dmarcConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DmarcConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dmarcName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DmarcName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastError", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastError
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastValidAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastValidAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mxBlackhole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MxBlackhole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mxConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MxConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextCheckAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextCheckAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reputation", typeJson: "{\"fqn\":\"scaleway.temDomain.TemDomainReputationList\"}")]
        public virtual scaleway.TemDomain.TemDomainReputationList Reputation
        {
            get => GetInstanceProperty<scaleway.TemDomain.TemDomainReputationList>()!;
        }

        [JsiiProperty(name: "revokedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevokedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smtpHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmtpHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smtpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmtpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smtpPortAlternative", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmtpPortAlternative
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smtpPortUnsecure", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmtpPortUnsecure
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smtpsAuthUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmtpsAuthUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smtpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmtpsPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smtpsPortAlternative", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmtpsPortAlternative
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "spfConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpfConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spfValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpfValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.temDomain.TemDomainTimeoutsOutputReference\"}")]
        public virtual scaleway.TemDomain.TemDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.TemDomain.TemDomainTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptTosInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptTosInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoconfigInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoconfigInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.temDomain.TemDomainTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "acceptTos", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AcceptTos
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "autoconfig", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Autoconfig
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
