using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreByoipRanges
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreByoipRangesByoipRangeCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "byoipRangeVcnIpv6Allocations", typeJson: "{\"fqn\":\"oci.dataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsByoipRangeVcnIpv6AllocationsList\"}")]
        public virtual oci.DataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsByoipRangeVcnIpv6AllocationsList ByoipRangeVcnIpv6Allocations
        {
            get => GetInstanceProperty<oci.DataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsByoipRangeVcnIpv6AllocationsList>()!;
        }

        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CidrBlock
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAnycastId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAnycastId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6CidrBlock
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitorIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitorIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAsn", typeJson: "{\"fqn\":\"oci.dataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsOriginAsnList\"}")]
        public virtual oci.DataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsOriginAsnList OriginAsn
        {
            get => GetInstanceProperty<oci.DataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItemsOriginAsnList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAdvertised", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAdvertised
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeWithdrawn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeWithdrawn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidationToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreByoipRanges.DataOciCoreByoipRangesByoipRangeCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCoreByoipRanges.IDataOciCoreByoipRangesByoipRangeCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreByoipRanges.IDataOciCoreByoipRangesByoipRangeCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
