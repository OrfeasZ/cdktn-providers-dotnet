using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata")]
    public interface IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_index DataLabelingServiceDataset#column_index}.</summary>
        [JsiiProperty(name: "columnIndex", typeJson: "{\"primitive\":\"number\"}")]
        double ColumnIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
        [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
        string FormatType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_delimiter DataLabelingServiceDataset#column_delimiter}.</summary>
        [JsiiProperty(name: "columnDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColumnDelimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_name DataLabelingServiceDataset#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#escape_character DataLabelingServiceDataset#escape_character}.</summary>
        [JsiiProperty(name: "escapeCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EscapeCharacter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#line_delimiter DataLabelingServiceDataset#line_delimiter}.</summary>
        [JsiiProperty(name: "lineDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LineDelimiter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_index DataLabelingServiceDataset#column_index}.</summary>
            [JsiiProperty(name: "columnIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double ColumnIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
            [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
            public string FormatType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_delimiter DataLabelingServiceDataset#column_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColumnDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#column_name DataLabelingServiceDataset#column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColumnName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#escape_character DataLabelingServiceDataset#escape_character}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "escapeCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EscapeCharacter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#line_delimiter DataLabelingServiceDataset#line_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lineDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LineDelimiter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
