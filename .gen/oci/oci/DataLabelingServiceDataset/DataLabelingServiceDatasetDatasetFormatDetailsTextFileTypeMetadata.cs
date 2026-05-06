using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata")]
    public class DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata : oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_index DataLabelingServiceDataset#column_index}.</summary>
        [JsiiProperty(name: "columnIndex", typeJson: "{\"primitive\":\"number\"}")]
        public double ColumnIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
        [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
        public string FormatType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_delimiter DataLabelingServiceDataset#column_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_name DataLabelingServiceDataset#column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#escape_character DataLabelingServiceDataset#escape_character}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "escapeCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EscapeCharacter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#line_delimiter DataLabelingServiceDataset#line_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lineDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LineDelimiter
        {
            get;
            set;
        }
    }
}
