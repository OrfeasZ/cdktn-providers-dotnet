using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run oci_devops_build_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsBuildRun.DevopsBuildRun), fullyQualifiedName: "oci.devopsBuildRun.DevopsBuildRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunConfig\"}}]")]
    public class DevopsBuildRun : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run oci_devops_build_run} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsBuildRun(Constructs.Construct scope, string id, oci.DevopsBuildRun.IDevopsBuildRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsBuildRun.IDevopsBuildRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsBuildRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsBuildRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsBuildRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsBuildRun to import.</param>
        /// <param name="importFromId">The id of the existing DevopsBuildRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsBuildRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsBuildRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsBuildRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsBuildRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsBuildRun.DevopsBuildRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBuildRunArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunArguments\"}}]")]
        public virtual void PutBuildRunArguments(oci.DevopsBuildRun.IDevopsBuildRunBuildRunArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildRun.IDevopsBuildRunBuildRunArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommitInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunCommitInfo\"}}]")]
        public virtual void PutCommitInfo(oci.DevopsBuildRun.IDevopsBuildRunCommitInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildRun.IDevopsBuildRunCommitInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsBuildRun.IDevopsBuildRunTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildRun.IDevopsBuildRunTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBuildRunArguments")]
        public virtual void ResetBuildRunArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommitInfo")]
        public virtual void ResetCommitInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DevopsBuildRun.DevopsBuildRun))!;

        [JsiiProperty(name: "buildOutputs", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildOutputsList\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunBuildOutputsList BuildOutputs
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunBuildOutputsList>()!;
        }

        [JsiiProperty(name: "buildRunArguments", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunArgumentsOutputReference\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunBuildRunArgumentsOutputReference BuildRunArguments
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunBuildRunArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "buildRunProgress", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunProgressList\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunBuildRunProgressList BuildRunProgress
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunBuildRunProgressList>()!;
        }

        [JsiiProperty(name: "buildRunSource", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunSourceList\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunBuildRunSourceList BuildRunSource
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunBuildRunSourceList>()!;
        }

        [JsiiProperty(name: "commitInfo", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunCommitInfoOutputReference\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunCommitInfoOutputReference CommitInfo
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunCommitInfoOutputReference>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunTimeoutsOutputReference\"}")]
        public virtual oci.DevopsBuildRun.DevopsBuildRunTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.DevopsBuildRunTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildPipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildPipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildRunArgumentsInput", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunArguments\"}", isOptional: true)]
        public virtual oci.DevopsBuildRun.IDevopsBuildRunBuildRunArguments? BuildRunArgumentsInput
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.IDevopsBuildRunBuildRunArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commitInfoInput", typeJson: "{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunCommitInfo\"}", isOptional: true)]
        public virtual oci.DevopsBuildRun.IDevopsBuildRunCommitInfo? CommitInfoInput
        {
            get => GetInstanceProperty<oci.DevopsBuildRun.IDevopsBuildRunCommitInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
