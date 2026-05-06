using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDefinedMetadataArtifact
{
    [JsiiByValue(fqn: "oci.datascienceModelDefinedMetadataArtifact.DatascienceModelDefinedMetadataArtifactTimeouts")]
    public class DatascienceModelDefinedMetadataArtifactTimeouts : oci.DatascienceModelDefinedMetadataArtifact.IDatascienceModelDefinedMetadataArtifactTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact#create DatascienceModelDefinedMetadataArtifact#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact#delete DatascienceModelDefinedMetadataArtifact#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_defined_metadata_artifact#update DatascienceModelDefinedMetadataArtifact#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
