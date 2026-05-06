using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management oci_os_management_hub_lifecycle_stage_detach_managed_instances_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagement), fullyQualifiedName: "oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementConfig\"}}]")]
    public class OsManagementHubLifecycleStageDetachManagedInstancesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management oci_os_management_hub_lifecycle_stage_detach_managed_instances_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubLifecycleStageDetachManagedInstancesManagement(Constructs.Construct scope, string id, oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubLifecycleStageDetachManagedInstancesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubLifecycleStageDetachManagedInstancesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubLifecycleStageDetachManagedInstancesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubLifecycleStageDetachManagedInstancesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubLifecycleStageDetachManagedInstancesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubLifecycleStageDetachManagedInstancesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubLifecycleStageDetachManagedInstancesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubLifecycleStageDetachManagedInstancesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubLifecycleStageDetachManagedInstancesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putManagedInstanceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails\"}}]")]
        public virtual void PutManagedInstanceDetails(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagement))!;

        [JsiiProperty(name: "managedInstanceDetails", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetailsOutputReference ManagedInstanceDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "managedInstanceDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails? ManagedInstanceDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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
    }
}
