using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageBuildRunnerShapeConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig")]
    public interface IDevopsBuildPipelineStageBuildRunnerShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_runner_type DevopsBuildPipelineStage#build_runner_type}.</summary>
        [JsiiProperty(name: "buildRunnerType", typeJson: "{\"primitive\":\"string\"}")]
        string BuildRunnerType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#memory_in_gbs DevopsBuildPipelineStage#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#ocpus DevopsBuildPipelineStage#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageBuildRunnerShapeConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildRunnerShapeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildRunnerShapeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#build_runner_type DevopsBuildPipelineStage#build_runner_type}.</summary>
            [JsiiProperty(name: "buildRunnerType", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildRunnerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#memory_in_gbs DevopsBuildPipelineStage#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#ocpus DevopsBuildPipelineStage#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
