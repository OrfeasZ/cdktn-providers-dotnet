using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalInfo", typeJson: "{\"fqn\":\"oci.dataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsApprovalInfoList\"}")]
        public virtual oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsApprovalInfoList ApprovalInfo
        {
            get => GetInstanceProperty<oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItemsApprovalInfoList>()!;
        }

        [JsiiProperty(name: "auditTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuditTypes
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "databaseNameList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatabaseNameList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "delegationControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DelegationControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delegationSubscriptionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DelegationSubscriptionIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "durationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extendDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtendDurationInHours
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "isAutoApproved", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoApproved
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPendingMoreInfo", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPendingMoreInfo
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numExtensionApprovals", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumExtensionApprovals
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numInitialApprovals", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumInitialApprovals
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "providedServiceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProvidedServiceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reasonForRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReasonForRequest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestedActionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequestedActionNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requesterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequesterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestStatus
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

        [JsiiProperty(name: "timeAccessRequested", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccessRequested
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDelegateAccessControlDelegatedResourceAccessRequests.DataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests.IDataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDelegateAccessControlDelegatedResourceAccessRequests.IDataOciDelegateAccessControlDelegatedResourceAccessRequestsDelegatedResourceAccessRequestSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
