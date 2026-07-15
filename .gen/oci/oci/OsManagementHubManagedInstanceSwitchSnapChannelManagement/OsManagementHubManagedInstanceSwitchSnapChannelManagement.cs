using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management oci_os_management_hub_managed_instance_switch_snap_channel_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagement), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementConfig\"}}]")]
    public class OsManagementHubManagedInstanceSwitchSnapChannelManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management oci_os_management_hub_managed_instance_switch_snap_channel_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagedInstanceSwitchSnapChannelManagement(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceSwitchSnapChannelManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstanceSwitchSnapChannelManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagedInstanceSwitchSnapChannelManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagedInstanceSwitchSnapChannelManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagedInstanceSwitchSnapChannelManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagedInstanceSwitchSnapChannelManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagedInstanceSwitchSnapChannelManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagedInstanceSwitchSnapChannelManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagedInstanceSwitchSnapChannelManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSnapDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails\"}}]")]
        public virtual void PutSnapDetails(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapDetails")]
        public virtual void ResetSnapDetails()
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagement))!;

        [JsiiProperty(name: "snapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetailsOutputReference SnapDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetailsOutputReference>()!;
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
        [JsiiProperty(name: "snapDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails? SnapDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails?>();
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
    }
}
