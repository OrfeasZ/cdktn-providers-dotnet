using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    [JsiiClass(nativeType: typeof(oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Max
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Min
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange\"}", isOptional: true)]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange? InternalValue
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange?>();
            set => SetInstanceProperty(value);
        }
    }
}
