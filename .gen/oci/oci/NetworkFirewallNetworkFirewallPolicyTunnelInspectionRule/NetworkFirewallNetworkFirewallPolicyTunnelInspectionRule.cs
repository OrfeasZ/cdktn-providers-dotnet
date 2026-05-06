using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule oci_network_firewall_network_firewall_policy_tunnel_inspection_rule}.</summary>
    [JsiiClass(nativeType: typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig\"}}]")]
    public class NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule oci_network_firewall_network_firewall_policy_tunnel_inspection_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule to import.</param>
        /// <param name="importFromId">The id of the existing NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition\"}}]")]
        public virtual void PutCondition(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPosition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition\"}}]")]
        public virtual void PutPosition(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile\"}}]")]
        public virtual void PutProfile(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosition")]
        public virtual void ResetPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
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
        = GetStaticProperty<string>(typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule))!;

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference Condition
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference>()!;
        }

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePositionOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePositionOutputReference Position
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePositionOutputReference>()!;
        }

        [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityOrder
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfileOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfileOutputReference Profile
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfileOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeoutsOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition? ConditionInput
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition?>();
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
        [JsiiProperty(name: "networkFirewallPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFirewallPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "positionInput", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition? PositionInput
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile? ProfileInput
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
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

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
