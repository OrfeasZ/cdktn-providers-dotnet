using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyCompletedApprovals
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsMetaList>()!;
        }

        [JsiiProperty(name: "myCompletedApprovalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MyCompletedApprovalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestCreatedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestCreatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseTime
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovalsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyCompletedApprovals.DataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovals\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyCompletedApprovals.IDataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovals? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyCompletedApprovals.IDataOciIdentityDomainsMyCompletedApprovalsMyCompletedApprovals?>();
            set => SetInstanceProperty(value);
        }
    }
}
