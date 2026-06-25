using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management oci_os_management_hub_managed_instance_attach_software_sources_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement), fullyQualifiedName: "oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementConfig\"}}]")]
    public class OsManagementHubManagedInstanceAttachSoftwareSourcesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management oci_os_management_hub_managed_instance_attach_software_sources_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagedInstanceAttachSoftwareSourcesManagement(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceAttachSoftwareSourcesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceAttachSoftwareSourcesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagedInstanceAttachSoftwareSourcesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagedInstanceAttachSoftwareSourcesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagedInstanceAttachSoftwareSourcesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagedInstanceAttachSoftwareSourcesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagedInstanceAttachSoftwareSourcesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagedInstanceAttachSoftwareSourcesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagedInstanceAttachSoftwareSourcesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareSourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SoftwareSourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SoftwareSources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
