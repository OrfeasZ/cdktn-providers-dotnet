using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOperatorAccessControlAccessRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessReasonSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessReasonSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "actionRequestsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ActionRequestsList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "approverComment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproverComment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approverDetails", typeJson: "{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsApproverDetailsList\"}")]
        public virtual oci.DataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsApproverDetailsList ApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsApproverDetailsList>()!;
        }

        [JsiiProperty(name: "auditType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuditType
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

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extendDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtendDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extensionApproverDetails", typeJson: "{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsExtensionApproverDetailsList\"}")]
        public virtual oci.DataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsExtensionApproverDetailsList ExtensionApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItemsExtensionApproverDetailsList>()!;
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

        [JsiiProperty(name: "isValidateAssignment", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsValidateAssignment
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfApprovers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfApprovers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfApproversRequired", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfApproversRequired
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfExtensionApprovers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfExtensionApprovers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opctlAdditionalMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpctlAdditionalMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opctlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpctlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opctlName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpctlName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "subResourceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubResourceList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "systemMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfCreation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfModification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfModification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfUserCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfUserCreation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRequestedForFutureAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRequestedForFutureAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workflowId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WorkflowId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequests.DataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOperatorAccessControlAccessRequests.IDataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOperatorAccessControlAccessRequests.IDataOciOperatorAccessControlAccessRequestsAccessRequestCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
