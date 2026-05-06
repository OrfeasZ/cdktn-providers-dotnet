using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_tunnel_inspection_rules oci_network_firewall_network_firewall_policy_tunnel_inspection_rules}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesConfig\"}}]")]
    public class DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_tunnel_inspection_rules oci_network_firewall_network_firewall_policy_tunnel_inspection_rules} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules(Constructs.Construct scope, string id, oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.IDataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.IDataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules to import.</param>
        /// <param name="importFromId">The id of the existing DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_tunnel_inspection_rules#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.IDataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.IDataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.IDataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnelInspectionRulePriorityOrder")]
        public virtual void ResetTunnelInspectionRulePriorityOrder()
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
        = GetStaticProperty<string>(typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilterList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilterList>()!;
        }

        [JsiiProperty(name: "tunnelInspectionRuleSummaryCollection", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesTunnelInspectionRuleSummaryCollectionList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesTunnelInspectionRuleSummaryCollectionList TunnelInspectionRuleSummaryCollection
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesTunnelInspectionRuleSummaryCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRules.DataOciNetworkFirewallNetworkFirewallPolicyTunnelInspectionRulesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
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
        [JsiiProperty(name: "networkFirewallPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFirewallPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnelInspectionRulePriorityOrderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TunnelInspectionRulePriorityOrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnelInspectionRulePriorityOrder", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TunnelInspectionRulePriorityOrder
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
