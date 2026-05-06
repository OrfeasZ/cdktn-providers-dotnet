using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule
{
    [JsiiClass(nativeType: typeof(oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyDecryptionRulePositionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAfterRule")]
        public virtual void ResetAfterRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBeforeRule")]
        public virtual void ResetBeforeRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "afterRuleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AfterRuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "beforeRuleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BeforeRuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "afterRule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AfterRule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "beforeRule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BeforeRule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePosition\"}", isOptional: true)]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition? InternalValue
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition?>();
            set => SetInstanceProperty(value);
        }
    }
}
