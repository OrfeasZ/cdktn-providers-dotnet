using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicySecurityRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule oci_network_firewall_network_firewall_policy_security_rule}.</summary>
    [JsiiClass(nativeType: typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRule), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleConfig\"}}]")]
    public class NetworkFirewallNetworkFirewallPolicySecurityRule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule oci_network_firewall_network_firewall_policy_security_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkFirewallNetworkFirewallPolicySecurityRule(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicySecurityRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicySecurityRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkFirewallNetworkFirewallPolicySecurityRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicySecurityRule to import.</param>
        /// <param name="importFromId">The id of the existing NetworkFirewallNetworkFirewallPolicySecurityRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicySecurityRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicySecurityRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkFirewallNetworkFirewallPolicySecurityRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicySecurityRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleCondition\"}}]")]
        public virtual void PutCondition(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPosition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePosition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPosition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRulePosition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRulePosition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRulePosition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInspection")]
        public virtual void ResetInspection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosition")]
        public virtual void ResetPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriorityOrder")]
        public virtual void ResetPriorityOrder()
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
        = GetStaticProperty<string>(typeof(oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRule))!;

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleConditionOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleConditionOutputReference Condition
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleConditionOutputReference>()!;
        }

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePositionList\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePositionList Position
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePositionList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleTimeoutsOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleCondition\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleCondition? ConditionInput
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inspectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InspectionInput
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
        [JsiiProperty(name: "positionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRulePosition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PositionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityOrderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityOrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "inspection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Inspection
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

        [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityOrder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
