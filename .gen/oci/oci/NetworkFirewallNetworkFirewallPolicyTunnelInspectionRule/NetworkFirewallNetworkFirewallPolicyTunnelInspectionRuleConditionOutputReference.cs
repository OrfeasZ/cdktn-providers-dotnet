using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    [JsiiClass(nativeType: typeof(oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDestinationAddress")]
        public virtual void ResetDestinationAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceAddress")]
        public virtual void ResetSourceAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationAddressInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DestinationAddressInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAddressInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SourceAddressInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DestinationAddress
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SourceAddress
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition? InternalValue
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
