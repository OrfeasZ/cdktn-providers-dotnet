using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenericArtifactsContentArtifactByPath
{
    [JsiiByValue(fqn: "oci.genericArtifactsContentArtifactByPath.GenericArtifactsContentArtifactByPathTimeouts")]
    public class GenericArtifactsContentArtifactByPathTimeouts : oci.GenericArtifactsContentArtifactByPath.IGenericArtifactsContentArtifactByPathTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#create GenericArtifactsContentArtifactByPath#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#delete GenericArtifactsContentArtifactByPath#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#update GenericArtifactsContentArtifactByPath#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
