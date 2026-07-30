using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackConfig\"}}]")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(Constructs.Construct scope, string id, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack to import.</param>
        /// <param name="importFromId">The id of the existing PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat" />)[]</param>
        [JsiiMethod(name: "putDestinationNat", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDestinationNat(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDnsSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings\"}}]")]
        public virtual void PutDnsSettings(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile\"}}]")]
        public virtual void PutNetworkProfile(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationNat")]
        public virtual void ResetDestinationNat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsSettings")]
        public virtual void ResetDnsSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarketplaceOfferId")]
        public virtual void ResetMarketplaceOfferId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlanId")]
        public virtual void ResetPlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack))!;

        [JsiiProperty(name: "destinationNat", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatList\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatList DestinationNat
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatList>()!;
        }

        [JsiiProperty(name: "dnsSettings", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsOutputReference DnsSettings
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileOutputReference NetworkProfile
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationNatInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DestinationNatInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsSettingsInput", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings? DnsSettingsInput
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketplaceOfferIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketplaceOfferIdInput
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
        [JsiiProperty(name: "networkProfileInput", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile? NetworkProfileInput
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulestackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RulestackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "marketplaceOfferId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketplaceOfferId
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

        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rulestackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RulestackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
