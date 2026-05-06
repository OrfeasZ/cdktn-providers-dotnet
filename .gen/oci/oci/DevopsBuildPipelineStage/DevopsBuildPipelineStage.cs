using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage oci_devops_build_pipeline_stage}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsBuildPipelineStage.DevopsBuildPipelineStage), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageConfig\"}}]")]
    public class DevopsBuildPipelineStage : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage oci_devops_build_pipeline_stage} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsBuildPipelineStage(Constructs.Construct scope, string id, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsBuildPipelineStage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsBuildPipelineStage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsBuildPipelineStage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsBuildPipelineStage to import.</param>
        /// <param name="importFromId">The id of the existing DevopsBuildPipelineStage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsBuildPipelineStage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsBuildPipelineStage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsBuildPipelineStage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsBuildPipelineStage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsBuildPipelineStage.DevopsBuildPipelineStage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBuildPipelineStagePredecessorCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection\"}}]")]
        public virtual void PutBuildPipelineStagePredecessorCollection(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBuildRunnerShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig\"}}]")]
        public virtual void PutBuildRunnerShapeConfig(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBuildSourceCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection\"}}]")]
        public virtual void PutBuildSourceCollection(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeliverArtifactCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection\"}}]")]
        public virtual void PutDeliverArtifactCollection(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateAccessConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig\"}}]")]
        public virtual void PutPrivateAccessConfig(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWaitCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria\"}}]")]
        public virtual void PutWaitCriteria(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBuildRunnerShapeConfig")]
        public virtual void ResetBuildRunnerShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildSourceCollection")]
        public virtual void ResetBuildSourceCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildSpecFile")]
        public virtual void ResetBuildSpecFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliverArtifactCollection")]
        public virtual void ResetDeliverArtifactCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployPipelineId")]
        public virtual void ResetDeployPipelineId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsPassAllParametersEnabled")]
        public virtual void ResetIsPassAllParametersEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryBuildSource")]
        public virtual void ResetPrimaryBuildSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateAccessConfig")]
        public virtual void ResetPrivateAccessConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageExecutionTimeoutInSeconds")]
        public virtual void ResetStageExecutionTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitCriteria")]
        public virtual void ResetWaitCriteria()
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
        = GetStaticProperty<string>(typeof(oci.DevopsBuildPipelineStage.DevopsBuildPipelineStage))!;

        [JsiiProperty(name: "buildPipelineStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionOutputReference BuildPipelineStagePredecessorCollection
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "buildRunnerShapeConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfigOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfigOutputReference BuildRunnerShapeConfig
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "buildSourceCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionOutputReference BuildSourceCollection
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deliverArtifactCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionOutputReference DeliverArtifactCollection
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateAccessConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfigOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfigOutputReference PrivateAccessConfig
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfigOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageTimeoutsOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteriaOutputReference\"}")]
        public virtual oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteriaOutputReference WaitCriteria
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteriaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildPipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildPipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildPipelineStagePredecessorCollectionInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection? BuildPipelineStagePredecessorCollectionInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildPipelineStageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildPipelineStageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildRunnerShapeConfigInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig? BuildRunnerShapeConfigInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildSourceCollectionInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection? BuildSourceCollectionInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildSpecFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildSpecFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliverArtifactCollectionInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection? DeliverArtifactCollectionInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployPipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployPipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isPassAllParametersEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsPassAllParametersEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryBuildSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryBuildSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateAccessConfigInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig? PrivateAccessConfigInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageExecutionTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StageExecutionTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitCriteriaInput", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria\"}", isOptional: true)]
        public virtual oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria? WaitCriteriaInput
        {
            get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria?>();
        }

        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "buildPipelineStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineStageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "buildSpecFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildSpecFile
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

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isPassAllParametersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsPassAllParametersEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "primaryBuildSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBuildSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StageExecutionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
