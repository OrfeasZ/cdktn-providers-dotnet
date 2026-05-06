using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting oci_devops_project_repository_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySetting), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingConfig\"}}]")]
    public class DevopsProjectRepositorySetting : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting oci_devops_project_repository_setting} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsProjectRepositorySetting(Constructs.Construct scope, string id, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsProjectRepositorySetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsProjectRepositorySetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsProjectRepositorySetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsProjectRepositorySetting to import.</param>
        /// <param name="importFromId">The id of the existing DevopsProjectRepositorySetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsProjectRepositorySetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsProjectRepositorySetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsProjectRepositorySetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsProjectRepositorySetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApprovalRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRules\"}}]")]
        public virtual void PutApprovalRules(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMergeSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettings\"}}]")]
        public virtual void PutMergeSettings(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApprovalRules")]
        public virtual void ResetApprovalRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMergeSettings")]
        public virtual void ResetMergeSettings()
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
        = GetStaticProperty<string>(typeof(oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySetting))!;

        [JsiiProperty(name: "approvalRules", typeJson: "{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesOutputReference\"}")]
        public virtual oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesOutputReference ApprovalRules
        {
            get => GetInstanceProperty<oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesOutputReference>()!;
        }

        [JsiiProperty(name: "mergeSettings", typeJson: "{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettingsOutputReference\"}")]
        public virtual oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettingsOutputReference MergeSettings
        {
            get => GetInstanceProperty<oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingTimeoutsOutputReference\"}")]
        public virtual oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsProjectRepositorySetting.DevopsProjectRepositorySettingTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalRulesInput", typeJson: "{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRules\"}", isOptional: true)]
        public virtual oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRules? ApprovalRulesInput
        {
            get => GetInstanceProperty<oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mergeSettingsInput", typeJson: "{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettings\"}", isOptional: true)]
        public virtual oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings? MergeSettingsInput
        {
            get => GetInstanceProperty<oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
