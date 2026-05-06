using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOperatorAccessControlAccessRequest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_access_request oci_operator_access_control_access_request}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequest), fullyQualifiedName: "oci.dataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestConfig\"}}]")]
    public class DataOciOperatorAccessControlAccessRequest : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_access_request oci_operator_access_control_access_request} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOperatorAccessControlAccessRequest(Constructs.Construct scope, string id, oci.DataOciOperatorAccessControlAccessRequest.IDataOciOperatorAccessControlAccessRequestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOperatorAccessControlAccessRequest.IDataOciOperatorAccessControlAccessRequestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOperatorAccessControlAccessRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOperatorAccessControlAccessRequest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOperatorAccessControlAccessRequest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOperatorAccessControlAccessRequest to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOperatorAccessControlAccessRequest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOperatorAccessControlAccessRequest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOperatorAccessControlAccessRequest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_access_request#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOperatorAccessControlAccessRequest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOperatorAccessControlAccessRequest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequest))!;

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

        [JsiiProperty(name: "approverDetails", typeJson: "{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestApproverDetailsList\"}")]
        public virtual oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestApproverDetailsList ApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestApproverDetailsList>()!;
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

        [JsiiProperty(name: "extensionApproverDetails", typeJson: "{\"fqn\":\"oci.dataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestExtensionApproverDetailsList\"}")]
        public virtual oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestExtensionApproverDetailsList ExtensionApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciOperatorAccessControlAccessRequest.DataOciOperatorAccessControlAccessRequestExtensionApproverDetailsList>()!;
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
        [JsiiProperty(name: "accessRequestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessRequestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessRequestId
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
