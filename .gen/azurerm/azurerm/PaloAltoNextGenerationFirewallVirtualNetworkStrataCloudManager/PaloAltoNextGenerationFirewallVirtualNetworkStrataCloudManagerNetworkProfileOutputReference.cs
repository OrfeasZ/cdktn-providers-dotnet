using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    [JsiiClass(nativeType: typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVnetConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration\"}}]")]
        public virtual void PutVnetConfiguration(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEgressNatIpAddressIds")]
        public virtual void ResetEgressNatIpAddressIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustedAddressRanges")]
        public virtual void ResetTrustedAddressRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "egressNatIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressNatIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "vnetConfiguration", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfigurationOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfigurationOutputReference VnetConfiguration
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressNatIpAddressIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EgressNatIpAddressIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpAddressIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PublicIpAddressIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedAddressRangesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TrustedAddressRangesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnetConfigurationInput", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration? VnetConfigurationInput
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration?>();
        }

        [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressNatIpAddressIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIpAddressIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrustedAddressRanges
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
