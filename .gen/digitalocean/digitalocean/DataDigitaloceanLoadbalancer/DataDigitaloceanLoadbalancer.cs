using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanLoadbalancer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/loadbalancer digitalocean_loadbalancer}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancer), fullyQualifiedName: "digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerConfig\"}}]")]
    public class DataDigitaloceanLoadbalancer : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/loadbalancer digitalocean_loadbalancer} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanLoadbalancer(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanLoadbalancer.IDataDigitaloceanLoadbalancerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanLoadbalancer.IDataDigitaloceanLoadbalancerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanLoadbalancer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanLoadbalancer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanLoadbalancer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanLoadbalancer to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanLoadbalancer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanLoadbalancer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanLoadbalancer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/loadbalancer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanLoadbalancer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanLoadbalancer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancer))!;

        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Algorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableLetsEncryptDnsRecords", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableLetsEncryptDnsRecords
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerDomainsList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerDomainsList Domains
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerDomainsList>()!;
        }

        [JsiiProperty(name: "dropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] DropletIds
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "dropletTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DropletTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableBackendKeepalive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableBackendKeepalive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableProxyProtocol
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "firewall", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerFirewallList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerFirewallList Firewall
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerFirewallList>()!;
        }

        [JsiiProperty(name: "forwardingRule", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerForwardingRuleList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerForwardingRuleList ForwardingRule
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerForwardingRuleList>()!;
        }

        [JsiiProperty(name: "glbSettings", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerGlbSettingsList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerGlbSettingsList GlbSettings
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerGlbSettingsList>()!;
        }

        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerHealthcheckList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerHealthcheckList Healthcheck
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerHealthcheckList>()!;
        }

        [JsiiProperty(name: "httpIdleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpIdleTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ip
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Network
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectHttpToHttps", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RedirectHttpToHttps
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Size
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeUnit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stickySessions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerStickySessionsList\"}")]
        public virtual digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerStickySessionsList StickySessions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanLoadbalancer.DataDigitaloceanLoadbalancerStickySessionsList>()!;
        }

        [JsiiProperty(name: "targetLoadBalancerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetLoadBalancerIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Urn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUuid
        {
            get => GetInstanceProperty<string>()!;
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
    }
}
