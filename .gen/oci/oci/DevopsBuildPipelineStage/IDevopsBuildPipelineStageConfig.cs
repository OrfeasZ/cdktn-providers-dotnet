using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageConfig")]
    public interface IDevopsBuildPipelineStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_id DevopsBuildPipelineStage#build_pipeline_id}.</summary>
        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string BuildPipelineId
        {
            get;
        }

        /// <summary>build_pipeline_stage_predecessor_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_stage_predecessor_collection DevopsBuildPipelineStage#build_pipeline_stage_predecessor_collection}
        /// </remarks>
        [JsiiProperty(name: "buildPipelineStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection\"}")]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection BuildPipelineStagePredecessorCollection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_stage_type DevopsBuildPipelineStage#build_pipeline_stage_type}.</summary>
        [JsiiProperty(name: "buildPipelineStageType", typeJson: "{\"primitive\":\"string\"}")]
        string BuildPipelineStageType
        {
            get;
        }

        /// <summary>build_runner_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_runner_shape_config DevopsBuildPipelineStage#build_runner_shape_config}
        /// </remarks>
        [JsiiProperty(name: "buildRunnerShapeConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig? BuildRunnerShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>build_source_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_source_collection DevopsBuildPipelineStage#build_source_collection}
        /// </remarks>
        [JsiiProperty(name: "buildSourceCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection? BuildSourceCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_spec_file DevopsBuildPipelineStage#build_spec_file}.</summary>
        [JsiiProperty(name: "buildSpecFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildSpecFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#defined_tags DevopsBuildPipelineStage#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>deliver_artifact_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#deliver_artifact_collection DevopsBuildPipelineStage#deliver_artifact_collection}
        /// </remarks>
        [JsiiProperty(name: "deliverArtifactCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection? DeliverArtifactCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#deploy_pipeline_id DevopsBuildPipelineStage#deploy_pipeline_id}.</summary>
        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployPipelineId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#description DevopsBuildPipelineStage#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#display_name DevopsBuildPipelineStage#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#freeform_tags DevopsBuildPipelineStage#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#id DevopsBuildPipelineStage#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#image DevopsBuildPipelineStage#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#is_pass_all_parameters_enabled DevopsBuildPipelineStage#is_pass_all_parameters_enabled}.</summary>
        [JsiiProperty(name: "isPassAllParametersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPassAllParametersEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#primary_build_source DevopsBuildPipelineStage#primary_build_source}.</summary>
        [JsiiProperty(name: "primaryBuildSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryBuildSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#private_access_config DevopsBuildPipelineStage#private_access_config}
        /// </remarks>
        [JsiiProperty(name: "privateAccessConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig? PrivateAccessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#stage_execution_timeout_in_seconds DevopsBuildPipelineStage#stage_execution_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "stageExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StageExecutionTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#timeouts DevopsBuildPipelineStage#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>wait_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_criteria DevopsBuildPipelineStage#wait_criteria}
        /// </remarks>
        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria? WaitCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_id DevopsBuildPipelineStage#build_pipeline_id}.</summary>
            [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildPipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>build_pipeline_stage_predecessor_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_stage_predecessor_collection DevopsBuildPipelineStage#build_pipeline_stage_predecessor_collection}
            /// </remarks>
            [JsiiProperty(name: "buildPipelineStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection\"}")]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection BuildPipelineStagePredecessorCollection
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_pipeline_stage_type DevopsBuildPipelineStage#build_pipeline_stage_type}.</summary>
            [JsiiProperty(name: "buildPipelineStageType", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildPipelineStageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>build_runner_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_runner_shape_config DevopsBuildPipelineStage#build_runner_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildRunnerShapeConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig? BuildRunnerShapeConfig
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig?>();
            }

            /// <summary>build_source_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_source_collection DevopsBuildPipelineStage#build_source_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildSourceCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection? BuildSourceCollection
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_spec_file DevopsBuildPipelineStage#build_spec_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildSpecFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildSpecFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#defined_tags DevopsBuildPipelineStage#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>deliver_artifact_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#deliver_artifact_collection DevopsBuildPipelineStage#deliver_artifact_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliverArtifactCollection", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection? DeliverArtifactCollection
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#deploy_pipeline_id DevopsBuildPipelineStage#deploy_pipeline_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployPipelineId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#description DevopsBuildPipelineStage#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#display_name DevopsBuildPipelineStage#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#freeform_tags DevopsBuildPipelineStage#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#id DevopsBuildPipelineStage#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#image DevopsBuildPipelineStage#image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#is_pass_all_parameters_enabled DevopsBuildPipelineStage#is_pass_all_parameters_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPassAllParametersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPassAllParametersEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#primary_build_source DevopsBuildPipelineStage#primary_build_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryBuildSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryBuildSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#private_access_config DevopsBuildPipelineStage#private_access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateAccessConfig", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig? PrivateAccessConfig
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#stage_execution_timeout_in_seconds DevopsBuildPipelineStage#stage_execution_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stageExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StageExecutionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#timeouts DevopsBuildPipelineStage#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageTimeouts\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageTimeouts?>();
            }

            /// <summary>wait_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_criteria DevopsBuildPipelineStage#wait_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria\"}", isOptional: true)]
            public oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria? WaitCriteria
            {
                get => GetInstanceProperty<oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
