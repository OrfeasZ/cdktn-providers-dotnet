using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreNetworkSecurityGroupSecurityRules
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference), fullyQualifiedName: "oci.dataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.dataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsDestinationPortRangeList\"}")]
        public virtual oci.DataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsDestinationPortRangeList DestinationPortRange
        {
            get => GetInstanceProperty<oci.DataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsDestinationPortRangeList>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.dataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsSourcePortRangeList\"}")]
        public virtual oci.DataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsSourcePortRangeList SourcePortRange
        {
            get => GetInstanceProperty<oci.DataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptionsSourcePortRangeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreNetworkSecurityGroupSecurityRules.DataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.DataOciCoreNetworkSecurityGroupSecurityRules.IDataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreNetworkSecurityGroupSecurityRules.IDataOciCoreNetworkSecurityGroupSecurityRulesSecurityRulesTcpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
