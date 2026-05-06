using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    [JsiiClass(nativeType: typeof(oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreNetworkSecurityGroupSecurityRuleTcpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRangeOutputReference\"}")]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRangeOutputReference\"}")]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange\"}", isOptional: true)]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange\"}", isOptional: true)]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
