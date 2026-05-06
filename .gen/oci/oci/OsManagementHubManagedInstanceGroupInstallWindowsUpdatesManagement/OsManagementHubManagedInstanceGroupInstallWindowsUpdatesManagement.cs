using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_install_windows_updates_management oci_os_management_hub_managed_instance_group_install_windows_updates_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementConfig\"}}]")]
    public class OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_install_windows_updates_management oci_os_management_hub_managed_instance_group_install_windows_updates_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_install_windows_updates_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedInstanceGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsUpdateTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WindowsUpdateTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceGroupInstallWindowsUpdatesManagementWorkRequestDetails?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedInstanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "windowsUpdateTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WindowsUpdateTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
