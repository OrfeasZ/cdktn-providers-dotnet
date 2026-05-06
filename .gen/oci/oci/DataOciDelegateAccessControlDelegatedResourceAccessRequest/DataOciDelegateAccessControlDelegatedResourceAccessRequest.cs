using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/delegate_access_control_delegated_resource_access_request oci_delegate_access_control_delegated_resource_access_request}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequest), fullyQualifiedName: "oci.dataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequestConfig\"}}]")]
    public class DataOciDelegateAccessControlDelegatedResourceAccessRequest : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/delegate_access_control_delegated_resource_access_request oci_delegate_access_control_delegated_resource_access_request} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDelegateAccessControlDelegatedResourceAccessRequest(Constructs.Construct scope, string id, oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.IDataOciDelegateAccessControlDelegatedResourceAccessRequestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.IDataOciDelegateAccessControlDelegatedResourceAccessRequestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDelegateAccessControlDelegatedResourceAccessRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDelegateAccessControlDelegatedResourceAccessRequest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDelegateAccessControlDelegatedResourceAccessRequest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDelegateAccessControlDelegatedResourceAccessRequest to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDelegateAccessControlDelegatedResourceAccessRequest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDelegateAccessControlDelegatedResourceAccessRequest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDelegateAccessControlDelegatedResourceAccessRequest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/delegate_access_control_delegated_resource_access_request#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDelegateAccessControlDelegatedResourceAccessRequest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDelegateAccessControlDelegatedResourceAccessRequest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequest))!;

        [JsiiProperty(name: "approvalInfo", typeJson: "{\"fqn\":\"oci.dataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequestApprovalInfoList\"}")]
        public virtual oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequestApprovalInfoList ApprovalInfo
        {
            get => GetInstanceProperty<oci.DataOciDelegateAccessControlDelegatedResourceAccessRequest.DataOciDelegateAccessControlDelegatedResourceAccessRequestApprovalInfoList>()!;
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
        [JsiiProperty(name: "delegatedResourceAccessRequestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DelegatedResourceAccessRequestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "delegatedResourceAccessRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DelegatedResourceAccessRequestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
