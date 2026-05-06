using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCapacityManagementNamespaceOccOverviews
{
    [JsiiClass(nativeType: typeof(oci.DataOciCapacityManagementNamespaceOccOverviews.DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCapacityManagementNamespaceOccOverviews.DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "capacityRequestsBlob", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityRequestsBlob
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "periodValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeriodValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalAvailable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalAvailable
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalCancelled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalCancelled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDemanded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalDemanded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalRejected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalRejected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSupplied", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSupplied
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalUnfulfilled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalUnfulfilled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Unit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workloadTypeBreakdownBlob", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadTypeBreakdownBlob
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementNamespaceOccOverviews.DataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCapacityManagementNamespaceOccOverviews.IDataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementNamespaceOccOverviews.IDataOciCapacityManagementNamespaceOccOverviewsOccOverviewCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
