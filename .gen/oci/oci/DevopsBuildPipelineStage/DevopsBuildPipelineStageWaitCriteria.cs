using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageWaitCriteria")]
    public class DevopsBuildPipelineStageWaitCriteria : oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageWaitCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_duration DevopsBuildPipelineStage#wait_duration}.</summary>
        [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
        public string WaitDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#wait_type DevopsBuildPipelineStage#wait_type}.</summary>
        [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
        public string WaitType
        {
            get;
            set;
        }
    }
}
