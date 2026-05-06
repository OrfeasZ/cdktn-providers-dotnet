using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkFirewallNetworkFirewallPolicyServices
{
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portRanges", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsPortRangesList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsPortRangesList PortRanges
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItemsPortRangesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyServices.DataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyServices.IDataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyServices.IDataOciNetworkFirewallNetworkFirewallPolicyServicesServiceSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
