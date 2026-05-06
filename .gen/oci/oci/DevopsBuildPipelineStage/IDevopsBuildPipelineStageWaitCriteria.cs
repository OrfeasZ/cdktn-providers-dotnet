using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageWaitCriteria), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria")]
    public interface IDevopsBuildPipelineStageWaitCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_duration DevopsBuildPipelineStage#wait_duration}.</summary>
        [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
        string WaitDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_type DevopsBuildPipelineStage#wait_type}.</summary>
        [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
        string WaitType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageWaitCriteria), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_duration DevopsBuildPipelineStage#wait_duration}.</summary>
            [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string WaitDuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_type DevopsBuildPipelineStage#wait_type}.</summary>
            [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
            public string WaitType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
