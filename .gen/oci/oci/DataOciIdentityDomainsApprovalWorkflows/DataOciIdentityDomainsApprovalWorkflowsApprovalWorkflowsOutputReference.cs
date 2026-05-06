using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApprovalWorkflows
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalWorkflowSteps", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsApprovalWorkflowStepsList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsApprovalWorkflowStepsList ApprovalWorkflowSteps
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsApprovalWorkflowStepsList>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "maxDuration", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMaxDurationList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMaxDurationList MaxDuration
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMaxDurationList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflowsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApprovalWorkflows.DataOciIdentityDomainsApprovalWorkflowsApprovalWorkflows\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsApprovalWorkflows.IDataOciIdentityDomainsApprovalWorkflowsApprovalWorkflows? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApprovalWorkflows.IDataOciIdentityDomainsApprovalWorkflowsApprovalWorkflows?>();
            set => SetInstanceProperty(value);
        }
    }
}
