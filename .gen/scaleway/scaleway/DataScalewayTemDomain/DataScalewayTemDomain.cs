using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayTemDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/tem_domain scaleway_tem_domain}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayTemDomain.DataScalewayTemDomain), fullyQualifiedName: "scaleway.dataScalewayTemDomain.DataScalewayTemDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayTemDomain.DataScalewayTemDomainConfig\"}}]")]
    public class DataScalewayTemDomain : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/tem_domain scaleway_tem_domain} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayTemDomain(Constructs.Construct scope, string id, scaleway.DataScalewayTemDomain.IDataScalewayTemDomainConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayTemDomain.IDataScalewayTemDomainConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayTemDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayTemDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayTemDomain resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayTemDomain to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayTemDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayTemDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayTemDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/tem_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayTemDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayTemDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayTemDomain.DataScalewayTemDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetDomainId")]
        public virtual void ResetDomainId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayTemDomain.DataScalewayTemDomain))!;

        [JsiiProperty(name: "acceptTos", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AcceptTos
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoconfig", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Autoconfig
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

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

        [JsiiProperty(name: "reputation", typeJson: "{\"fqn\":\"scaleway.dataScalewayTemDomain.DataScalewayTemDomainReputationList\"}")]
        public virtual scaleway.DataScalewayTemDomain.DataScalewayTemDomainReputationList Reputation
        {
            get => GetInstanceProperty<scaleway.DataScalewayTemDomain.DataScalewayTemDomainReputationList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "domainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
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
