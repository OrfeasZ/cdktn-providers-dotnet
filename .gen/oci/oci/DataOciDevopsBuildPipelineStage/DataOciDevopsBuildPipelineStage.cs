using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsBuildPipelineStage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_build_pipeline_stage oci_devops_build_pipeline_stage}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStage), fullyQualifiedName: "oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageConfig\"}}]")]
    public class DataOciDevopsBuildPipelineStage : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_build_pipeline_stage oci_devops_build_pipeline_stage} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDevopsBuildPipelineStage(Constructs.Construct scope, string id, oci.DataOciDevopsBuildPipelineStage.IDataOciDevopsBuildPipelineStageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDevopsBuildPipelineStage.IDataOciDevopsBuildPipelineStageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsBuildPipelineStage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsBuildPipelineStage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDevopsBuildPipelineStage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDevopsBuildPipelineStage to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDevopsBuildPipelineStage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDevopsBuildPipelineStage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDevopsBuildPipelineStage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_build_pipeline_stage#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDevopsBuildPipelineStage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDevopsBuildPipelineStage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStage))!;

        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildPipelineStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionList BuildPipelineStagePredecessorCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionList>()!;
        }

        [JsiiProperty(name: "buildPipelineStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineStageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildRunnerShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildRunnerShapeConfigList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildRunnerShapeConfigList BuildRunnerShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildRunnerShapeConfigList>()!;
        }

        [JsiiProperty(name: "buildSourceCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildSourceCollectionList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildSourceCollectionList BuildSourceCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageBuildSourceCollectionList>()!;
        }

        [JsiiProperty(name: "buildSpecFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildSpecFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deliverArtifactCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageDeliverArtifactCollectionList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageDeliverArtifactCollectionList DeliverArtifactCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageDeliverArtifactCollectionList>()!;
        }

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPassAllParametersEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPassAllParametersEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBuildSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBuildSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateAccessConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStagePrivateAccessConfigList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStagePrivateAccessConfigList PrivateAccessConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStagePrivateAccessConfigList>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stageExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StageExecutionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageWaitCriteriaList\"}")]
        public virtual oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageWaitCriteriaList WaitCriteria
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildPipelineStage.DataOciDevopsBuildPipelineStageWaitCriteriaList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildPipelineStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildPipelineStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildPipelineStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildPipelineStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
