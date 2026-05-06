using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreIpInventorySubnet
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreIpInventorySubnet.DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference), fullyQualifiedName: "oci.dataOciCoreIpInventorySubnet.DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assignedResourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignedResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assignedResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignedResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assignedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatedPublicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedPublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatedPublicIpPool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedPublicIpPool
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsHostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsHostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddressLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressLifetime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpLifetime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreIpInventorySubnet.DataOciCoreIpInventorySubnetIpInventorySubnetResourceSummary\"}", isOptional: true)]
        public virtual oci.DataOciCoreIpInventorySubnet.IDataOciCoreIpInventorySubnetIpInventorySubnetResourceSummary? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreIpInventorySubnet.IDataOciCoreIpInventorySubnetIpInventorySubnetResourceSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}
