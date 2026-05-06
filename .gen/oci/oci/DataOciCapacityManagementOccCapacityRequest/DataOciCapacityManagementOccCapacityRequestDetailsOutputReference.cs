using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCapacityManagementOccCapacityRequest
{
    [JsiiClass(nativeType: typeof(oci.DataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetailsOutputReference), fullyQualifiedName: "oci.dataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCapacityManagementOccCapacityRequestDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCapacityManagementOccCapacityRequestDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCapacityManagementOccCapacityRequestDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementOccCapacityRequestDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actualHandoverQuantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActualHandoverQuantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatedOccHandoverResourceBlockList", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStructList\"}")]
        public virtual oci.DataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStructList AssociatedOccHandoverResourceBlockList
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStructList>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateActualHandover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateActualHandover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateExpectedHandover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateExpectedHandover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "demandQuantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DemandQuantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedHandoverQuantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedHandoverQuantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceWorkloadType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementOccCapacityRequest.DataOciCapacityManagementOccCapacityRequestDetails\"}", isOptional: true)]
        public virtual oci.DataOciCapacityManagementOccCapacityRequest.IDataOciCapacityManagementOccCapacityRequestDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementOccCapacityRequest.IDataOciCapacityManagementOccCapacityRequestDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
