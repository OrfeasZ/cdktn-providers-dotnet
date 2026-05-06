using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails")]
    public class DataLabelingServiceDatasetDatasetFormatDetails : oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
        [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
        public string FormatType
        {
            get;
            set;
        }

        /// <summary>text_file_type_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#text_file_type_metadata DataLabelingServiceDataset#text_file_type_metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "textFileTypeMetadata", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata\"}", isOptional: true)]
        public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata? TextFileTypeMetadata
        {
            get;
            set;
        }
    }
}
