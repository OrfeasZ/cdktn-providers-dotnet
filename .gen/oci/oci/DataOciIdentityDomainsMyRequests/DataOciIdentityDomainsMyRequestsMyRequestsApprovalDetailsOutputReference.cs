using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovalType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approverDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproverDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproverId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetails\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyRequests.IDataOciIdentityDomainsMyRequestsMyRequestsApprovalDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.IDataOciIdentityDomainsMyRequestsMyRequestsApprovalDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
