using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerRoutingRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_routing_rule azurerm_network_manager_routing_rule}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRule), fullyQualifiedName: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleConfig\"}}]")]
    public class NetworkManagerRoutingRule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_routing_rule azurerm_network_manager_routing_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkManagerRoutingRule(Constructs.Construct scope, string id, azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkManagerRoutingRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkManagerRoutingRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkManagerRoutingRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkManagerRoutingRule to import.</param>
        /// <param name="importFromId">The id of the existing NetworkManagerRoutingRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkManagerRoutingRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkManagerRoutingRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/network_manager_routing_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkManagerRoutingRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkManagerRoutingRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleDestination\"}}]")]
        public virtual void PutDestination(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNextHop", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHop\"}}]")]
        public virtual void PutNextHop(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRule))!;

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleDestinationOutputReference\"}")]
        public virtual azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleDestinationOutputReference Destination
        {
            get => GetInstanceProperty<azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "nextHop", typeJson: "{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHopOutputReference\"}")]
        public virtual azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleNextHopOutputReference NextHop
        {
            get => GetInstanceProperty<azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleNextHopOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleTimeoutsOutputReference\"}")]
        public virtual azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetworkManagerRoutingRule.NetworkManagerRoutingRuleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleDestination\"}", isOptional: true)]
        public virtual azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleDestination? DestinationInput
        {
            get => GetInstanceProperty<azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleDestination?>();
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
        [JsiiProperty(name: "nextHopInput", typeJson: "{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHop\"}", isOptional: true)]
        public virtual azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop? NextHopInput
        {
            get => GetInstanceProperty<azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleCollectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleCollectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "ruleCollectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleCollectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
