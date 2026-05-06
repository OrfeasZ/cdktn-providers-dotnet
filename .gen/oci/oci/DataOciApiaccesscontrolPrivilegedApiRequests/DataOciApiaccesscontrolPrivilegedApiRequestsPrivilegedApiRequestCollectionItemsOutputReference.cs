using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApiaccesscontrolPrivilegedApiRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approverDetails", typeJson: "{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsApproverDetailsList\"}")]
        public virtual oci.DataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsApproverDetailsList ApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsApproverDetailsList>()!;
        }

        [JsiiProperty(name: "closureComment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClosureComment
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

        [JsiiProperty(name: "durationInHrs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInHrs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityType
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationTopicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTopicId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfApproversRequired", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfApproversRequired
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privilegedApiControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegedApiControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilegedApiControlName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegedApiControlName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilegedOperationList", typeJson: "{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsPrivilegedOperationListStructList\"}")]
        public virtual oci.DataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsPrivilegedOperationListStructList PrivilegedOperationList
        {
            get => GetInstanceProperty<oci.DataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItemsPrivilegedOperationListStructList>()!;
        }

        [JsiiProperty(name: "reasonDetail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReasonDetail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reasonSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReasonSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestedBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequestedBy
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
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

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subResourceNameList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubResourceNameList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "ticketNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TicketNumbers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRequestedForFutureAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRequestedForFutureAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequests.DataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciApiaccesscontrolPrivilegedApiRequests.IDataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApiaccesscontrolPrivilegedApiRequests.IDataOciApiaccesscontrolPrivilegedApiRequestsPrivilegedApiRequestCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
