using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyRequests
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyRequestsMyRequestsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyRequestsMyRequestsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyRequestsMyRequestsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyRequestsMyRequestsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approvalDetails", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsList ApprovalDetails
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsApprovalDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsMetaList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requesting", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestingList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestingList Requesting
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestingList>()!;
        }

        [JsiiProperty(name: "requestor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestorList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestorList Requestor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsRequestorList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequestsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequests.DataOciIdentityDomainsMyRequestsMyRequests\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyRequests.IDataOciIdentityDomainsMyRequestsMyRequests? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequests.IDataOciIdentityDomainsMyRequestsMyRequests?>();
            set => SetInstanceProperty(value);
        }
    }
}
