using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ArtifactsContainerRepository
{
    [JsiiByValue(fqn: "oci.artifactsContainerRepository.ArtifactsContainerRepositoryTimeouts")]
    public class ArtifactsContainerRepositoryTimeouts : oci.ArtifactsContainerRepository.IArtifactsContainerRepositoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#create ArtifactsContainerRepository#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#delete ArtifactsContainerRepository#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#update ArtifactsContainerRepository#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
