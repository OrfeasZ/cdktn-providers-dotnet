using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelCustomMetadataArtifact
{
    [JsiiByValue(fqn: "oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeouts")]
    public class DatascienceModelCustomMetadataArtifactTimeouts : oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#create DatascienceModelCustomMetadataArtifact#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#delete DatascienceModelCustomMetadataArtifact#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#update DatascienceModelCustomMetadataArtifact#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
