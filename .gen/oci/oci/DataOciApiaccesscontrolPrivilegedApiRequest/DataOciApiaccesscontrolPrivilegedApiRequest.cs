using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApiaccesscontrolPrivilegedApiRequest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apiaccesscontrol_privileged_api_request oci_apiaccesscontrol_privileged_api_request}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequest), fullyQualifiedName: "oci.dataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestConfig\"}}]")]
    public class DataOciApiaccesscontrolPrivilegedApiRequest : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apiaccesscontrol_privileged_api_request oci_apiaccesscontrol_privileged_api_request} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciApiaccesscontrolPrivilegedApiRequest(Constructs.Construct scope, string id, oci.DataOciApiaccesscontrolPrivilegedApiRequest.IDataOciApiaccesscontrolPrivilegedApiRequestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciApiaccesscontrolPrivilegedApiRequest.IDataOciApiaccesscontrolPrivilegedApiRequestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApiaccesscontrolPrivilegedApiRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApiaccesscontrolPrivilegedApiRequest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciApiaccesscontrolPrivilegedApiRequest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciApiaccesscontrolPrivilegedApiRequest to import.</param>
        /// <param name="importFromId">The id of the existing DataOciApiaccesscontrolPrivilegedApiRequest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciApiaccesscontrolPrivilegedApiRequest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciApiaccesscontrolPrivilegedApiRequest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apiaccesscontrol_privileged_api_request#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciApiaccesscontrolPrivilegedApiRequest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciApiaccesscontrolPrivilegedApiRequest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequest))!;

        [JsiiProperty(name: "approverDetails", typeJson: "{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestApproverDetailsList\"}")]
        public virtual oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestApproverDetailsList ApproverDetails
        {
            get => GetInstanceProperty<oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestApproverDetailsList>()!;
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

        [JsiiProperty(name: "privilegedOperationList", typeJson: "{\"fqn\":\"oci.dataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStructList\"}")]
        public virtual oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStructList PrivilegedOperationList
        {
            get => GetInstanceProperty<oci.DataOciApiaccesscontrolPrivilegedApiRequest.DataOciApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStructList>()!;
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
        [JsiiProperty(name: "privilegedApiRequestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivilegedApiRequestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "privilegedApiRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegedApiRequestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
