using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetInstallPackagesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/os_management_hub_dynamic_set_install_packages_management oci_os_management_hub_dynamic_set_install_packages_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagement), fullyQualifiedName: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementConfig\"}}]")]
    public class OsManagementHubDynamicSetInstallPackagesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/os_management_hub_dynamic_set_install_packages_management oci_os_management_hub_dynamic_set_install_packages_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubDynamicSetInstallPackagesManagement(Constructs.Construct scope, string id, oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubDynamicSetInstallPackagesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubDynamicSetInstallPackagesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubDynamicSetInstallPackagesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubDynamicSetInstallPackagesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubDynamicSetInstallPackagesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubDynamicSetInstallPackagesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubDynamicSetInstallPackagesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubDynamicSetInstallPackagesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubDynamicSetInstallPackagesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkRequestDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails\"}}]")]
        public virtual void PutWorkRequestDetails(oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedInstances")]
        public virtual void ResetManagedInstances()
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetailsOutputReference WorkRequestDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamicSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DynamicSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInstancesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ManagedInstancesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PackageNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails? WorkRequestDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails?>();
        }

        [JsiiProperty(name: "dynamicSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicSetId
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

        [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ManagedInstances
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PackageNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
