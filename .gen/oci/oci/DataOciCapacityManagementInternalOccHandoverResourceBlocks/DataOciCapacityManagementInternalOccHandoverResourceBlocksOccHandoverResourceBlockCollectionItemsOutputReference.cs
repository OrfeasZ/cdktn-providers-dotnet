using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks
{
    [JsiiClass(nativeType: typeof(oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedCapacityRequests", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsAssociatedCapacityRequestsList\"}")]
        public virtual oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsAssociatedCapacityRequestsList AssociatedCapacityRequests
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsAssociatedCapacityRequestsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handoverDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandoverDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handoverResourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandoverResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "occCustomerGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OccCustomerGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementDetails", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsPlacementDetailsList\"}")]
        public virtual oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsPlacementDetailsList PlacementDetails
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItemsPlacementDetailsList>()!;
        }

        [JsiiProperty(name: "totalHandoverQuantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalHandoverQuantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementInternalOccHandoverResourceBlocks.DataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.IDataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementInternalOccHandoverResourceBlocks.IDataOciCapacityManagementInternalOccHandoverResourceBlocksOccHandoverResourceBlockCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
