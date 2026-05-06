using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepArtifact")]
    public class DatasciencePipelineStepArtifact : oci.DatasciencePipeline.IDatasciencePipelineStepArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#pipeline_step_artifact DatasciencePipeline#pipeline_step_artifact}.</summary>
        [JsiiProperty(name: "pipelineStepArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public string PipelineStepArtifact
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public string StepName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_disposition DatasciencePipeline#artifact_content_disposition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactContentDisposition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_length DatasciencePipeline#artifact_content_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactContentLength
        {
            get;
            set;
        }
    }
}
