using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ArtifactsContainerRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.artifactsContainerRepository.ArtifactsContainerRepositoryReadme")]
    public class ArtifactsContainerRepositoryReadme : oci.ArtifactsContainerRepository.IArtifactsContainerRepositoryReadme
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#content ArtifactsContainerRepository#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#format ArtifactsContainerRepository#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }
    }
}
