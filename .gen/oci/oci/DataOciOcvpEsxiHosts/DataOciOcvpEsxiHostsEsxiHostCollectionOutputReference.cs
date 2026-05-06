using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpEsxiHosts
{
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference), fullyQualifiedName: "oci.dataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpEsxiHostsEsxiHostCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "billingContractEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingContractEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingDonorHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingDonorHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datastoreAttachments", typeJson: "{\"fqn\":\"oci.dataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollectionDatastoreAttachmentsList\"}")]
        public virtual oci.DataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollectionDatastoreAttachmentsList DatastoreAttachments
        {
            get => GetInstanceProperty<oci.DataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollectionDatastoreAttachmentsList>()!;
        }

        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DetachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "esxiSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gracePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracePeriodEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBillingContinuationInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBillingContinuationInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isBillingSwappingInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBillingSwappingInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nextCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonUpgradedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonUpgradedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replacementEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "swapBillingHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwapBillingHostId
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

        [JsiiProperty(name: "upgradedReplacementEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradedReplacementEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmwareSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOcvpEsxiHosts.DataOciOcvpEsxiHostsEsxiHostCollection\"}", isOptional: true)]
        public virtual oci.DataOciOcvpEsxiHosts.IDataOciOcvpEsxiHostsEsxiHostCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOcvpEsxiHosts.IDataOciOcvpEsxiHostsEsxiHostCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
