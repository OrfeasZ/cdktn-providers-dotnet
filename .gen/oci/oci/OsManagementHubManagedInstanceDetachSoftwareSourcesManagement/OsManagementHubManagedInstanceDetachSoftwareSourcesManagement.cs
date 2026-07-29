using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management oci_os_management_hub_managed_instance_detach_software_sources_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement), fullyQualifiedName: "oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementConfig\"}}]")]
    public class OsManagementHubManagedInstanceDetachSoftwareSourcesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management oci_os_management_hub_managed_instance_detach_software_sources_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagedInstanceDetachSoftwareSourcesManagement(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceDetachSoftwareSourcesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceDetachSoftwareSourcesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagedInstanceDetachSoftwareSourcesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagedInstanceDetachSoftwareSourcesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagedInstanceDetachSoftwareSourcesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagedInstanceDetachSoftwareSourcesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagedInstanceDetachSoftwareSourcesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagedInstanceDetachSoftwareSourcesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagedInstanceDetachSoftwareSourcesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetailsOutputReference>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails?>();
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
