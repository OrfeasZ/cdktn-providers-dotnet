using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiByValue(fqn: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionItems")]
    public class DevopsBuildPipelineStageDeliverArtifactCollectionItems : oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollectionItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_id DevopsBuildPipelineStage#artifact_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_name DevopsBuildPipelineStage#artifact_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactName
        {
            get;
            set;
        }
    }
}
