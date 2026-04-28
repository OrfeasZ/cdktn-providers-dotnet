using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer digitalocean_loadbalancer}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.Loadbalancer.Loadbalancer), fullyQualifiedName: "digitalocean.loadbalancer.Loadbalancer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerConfig\"}}]")]
    public class Loadbalancer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer digitalocean_loadbalancer} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Loadbalancer(Constructs.Construct scope, string id, digitalocean.Loadbalancer.ILoadbalancerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.Loadbalancer.ILoadbalancerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Loadbalancer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Loadbalancer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Loadbalancer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Loadbalancer to import.</param>
        /// <param name="importFromId">The id of the existing Loadbalancer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Loadbalancer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Loadbalancer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Loadbalancer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Loadbalancer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.Loadbalancer.Loadbalancer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDomains", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerDomains\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDomains(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.Loadbalancer.ILoadbalancerDomains[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.Loadbalancer.ILoadbalancerDomains).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.Loadbalancer.ILoadbalancerDomains).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirewall", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerFirewall\"}}]")]
        public virtual void PutFirewall(digitalocean.Loadbalancer.ILoadbalancerFirewall @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.Loadbalancer.ILoadbalancerFirewall)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForwardingRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerForwardingRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutForwardingRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.Loadbalancer.ILoadbalancerForwardingRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.Loadbalancer.ILoadbalancerForwardingRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.Loadbalancer.ILoadbalancerForwardingRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGlbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettings\"}}]")]
        public virtual void PutGlbSettings(digitalocean.Loadbalancer.ILoadbalancerGlbSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.Loadbalancer.ILoadbalancerGlbSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerHealthcheck\"}}]")]
        public virtual void PutHealthcheck(digitalocean.Loadbalancer.ILoadbalancerHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.Loadbalancer.ILoadbalancerHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStickySessions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerStickySessions\"}}]")]
        public virtual void PutStickySessions(digitalocean.Loadbalancer.ILoadbalancerStickySessions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.Loadbalancer.ILoadbalancerStickySessions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlgorithm")]
        public virtual void ResetAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableLetsEncryptDnsRecords")]
        public virtual void ResetDisableLetsEncryptDnsRecords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomains")]
        public virtual void ResetDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDropletIds")]
        public virtual void ResetDropletIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDropletTag")]
        public virtual void ResetDropletTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableBackendKeepalive")]
        public virtual void ResetEnableBackendKeepalive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableProxyProtocol")]
        public virtual void ResetEnableProxyProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirewall")]
        public virtual void ResetFirewall()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardingRule")]
        public virtual void ResetForwardingRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlbSettings")]
        public virtual void ResetGlbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthcheck")]
        public virtual void ResetHealthcheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpIdleTimeoutSeconds")]
        public virtual void ResetHttpIdleTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkStack")]
        public virtual void ResetNetworkStack()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectHttpToHttps")]
        public virtual void ResetRedirectHttpToHttps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSize")]
        public virtual void ResetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizeUnit")]
        public virtual void ResetSizeUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStickySessions")]
        public virtual void ResetStickySessions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetLoadBalancerIds")]
        public virtual void ResetTargetLoadBalancerIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsCipherPolicy")]
        public virtual void ResetTlsCipherPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcUuid")]
        public virtual void ResetVpcUuid()
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
        = GetStaticProperty<string>(typeof(digitalocean.Loadbalancer.Loadbalancer))!;

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerDomainsList\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerDomainsList Domains
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerDomainsList>()!;
        }

        [JsiiProperty(name: "firewall", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerFirewallOutputReference\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerFirewallOutputReference Firewall
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerFirewallOutputReference>()!;
        }

        [JsiiProperty(name: "forwardingRule", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerForwardingRuleList\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerForwardingRuleList ForwardingRule
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerForwardingRuleList>()!;
        }

        [JsiiProperty(name: "glbSettings", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsOutputReference\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerGlbSettingsOutputReference GlbSettings
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerGlbSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerHealthcheckOutputReference\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerHealthcheckOutputReference Healthcheck
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerHealthcheckOutputReference>()!;
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stickySessions", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerStickySessionsOutputReference\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerStickySessionsOutputReference StickySessions
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerStickySessionsOutputReference>()!;
        }

        [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Urn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "algorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableLetsEncryptDnsRecordsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableLetsEncryptDnsRecordsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerDomains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DomainsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dropletIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? DropletIdsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dropletTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DropletTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableBackendKeepaliveInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableBackendKeepaliveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableProxyProtocolInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableProxyProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firewallInput", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerFirewall\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerFirewall? FirewallInput
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerFirewall?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardingRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerForwardingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ForwardingRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "glbSettingsInput", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettings\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerGlbSettings? GlbSettingsInput
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerGlbSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthcheckInput", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerHealthcheck\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerHealthcheck? HealthcheckInput
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpIdleTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpIdleTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "networkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkStackInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkStackInput
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
        [JsiiProperty(name: "redirectHttpToHttpsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RedirectHttpToHttpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeUnitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeUnitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickySessionsInput", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerStickySessions\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerStickySessions? StickySessionsInput
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerStickySessions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetLoadBalancerIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetLoadBalancerIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsCipherPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsCipherPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcUuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcUuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Algorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableLetsEncryptDnsRecords", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisableLetsEncryptDnsRecords
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

        [JsiiProperty(name: "dropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] DropletIds
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dropletTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DropletTag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableBackendKeepalive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableBackendKeepalive
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

        [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableProxyProtocol
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

        [JsiiProperty(name: "httpIdleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpIdleTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Network
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkStack", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkStack
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

        [JsiiProperty(name: "redirectHttpToHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RedirectHttpToHttps
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Size
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeUnit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetLoadBalancerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetLoadBalancerIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsCipherPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCipherPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
