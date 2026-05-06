using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computeCapacityTopologyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeCapacityTopologyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeHpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeHpcIslandId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalComputeBareMetalHostCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalComputeBareMetalHostCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
