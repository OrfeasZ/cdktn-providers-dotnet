using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiClass(nativeType: typeof(aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBypassDestinationValidationIpRanges")]
        public virtual void ResetBypassDestinationValidationIpRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIpRanges")]
        public virtual void ResetSourceIpRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bypassDestinationValidationIpRangesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BypassDestinationValidationIpRangesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsExpiryExceptionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsExpiryExceptionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsFirewallRuleGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsFirewallRuleGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpRangesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SourceIpRangesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bypassDestinationValidationIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BypassDestinationValidationIpRanges
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsExpiryExceptionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsExpiryExceptionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsFirewallRuleGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsFirewallRuleGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SourceIpRanges
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation\"}", isOptional: true)]
        public virtual aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation?>();
            set => SetInstanceProperty(value);
        }
    }
}
