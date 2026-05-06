using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management oci_os_management_hub_lifecycle_stage_promote_software_source_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement), fullyQualifiedName: "oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementConfig\"}}]")]
    public class OsManagementHubLifecycleStagePromoteSoftwareSourceManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management oci_os_management_hub_lifecycle_stage_promote_software_source_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubLifecycleStagePromoteSoftwareSourceManagement(Constructs.Construct scope, string id, oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubLifecycleStagePromoteSoftwareSourceManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubLifecycleStagePromoteSoftwareSourceManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubLifecycleStagePromoteSoftwareSourceManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubLifecycleStagePromoteSoftwareSourceManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubLifecycleStagePromoteSoftwareSourceManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubLifecycleStagePromoteSoftwareSourceManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubLifecycleStagePromoteSoftwareSourceManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubLifecycleStagePromoteSoftwareSourceManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubLifecycleStagePromoteSoftwareSourceManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareSourceId")]
        public virtual void ResetSoftwareSourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkRequestDetails")]
        public virtual void ResetWorkRequestDetails()
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LifecycleStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwareSourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
