using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting oci_devops_repository_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsRepositorySetting.DevopsRepositorySetting), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingConfig\"}}]")]
    public class DevopsRepositorySetting : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting oci_devops_repository_setting} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsRepositorySetting(Constructs.Construct scope, string id, oci.DevopsRepositorySetting.IDevopsRepositorySettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsRepositorySetting.IDevopsRepositorySettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsRepositorySetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsRepositorySetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsRepositorySetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsRepositorySetting to import.</param>
        /// <param name="importFromId">The id of the existing DevopsRepositorySetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsRepositorySetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsRepositorySetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsRepositorySetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsRepositorySetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsRepositorySetting.DevopsRepositorySetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApprovalRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRules\"}}]")]
        public virtual void PutApprovalRules(oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMergeChecks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks\"}}]")]
        public virtual void PutMergeChecks(oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMergeSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeSettings\"}}]")]
        public virtual void PutMergeSettings(oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsRepositorySetting.IDevopsRepositorySettingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsRepositorySetting.IDevopsRepositorySettingTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetMergeChecks")]
        public virtual void ResetMergeChecks()
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
        = GetStaticProperty<string>(typeof(oci.DevopsRepositorySetting.DevopsRepositorySetting))!;

        [JsiiProperty(name: "approvalRules", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesOutputReference\"}")]
        public virtual oci.DevopsRepositorySetting.DevopsRepositorySettingApprovalRulesOutputReference ApprovalRules
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.DevopsRepositorySettingApprovalRulesOutputReference>()!;
        }

        [JsiiProperty(name: "mergeChecks", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecksOutputReference\"}")]
        public virtual oci.DevopsRepositorySetting.DevopsRepositorySettingMergeChecksOutputReference MergeChecks
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.DevopsRepositorySettingMergeChecksOutputReference>()!;
        }

        [JsiiProperty(name: "mergeSettings", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeSettingsOutputReference\"}")]
        public virtual oci.DevopsRepositorySetting.DevopsRepositorySettingMergeSettingsOutputReference MergeSettings
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.DevopsRepositorySettingMergeSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingTimeoutsOutputReference\"}")]
        public virtual oci.DevopsRepositorySetting.DevopsRepositorySettingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.DevopsRepositorySettingTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalRulesInput", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRules\"}", isOptional: true)]
        public virtual oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRules? ApprovalRulesInput
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mergeChecksInput", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks\"}", isOptional: true)]
        public virtual oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks? MergeChecksInput
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mergeSettingsInput", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeSettings\"}", isOptional: true)]
        public virtual oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeSettings? MergeSettingsInput
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
