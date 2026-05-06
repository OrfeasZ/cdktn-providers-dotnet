using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetDatasetFormatDetails), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails")]
    public interface IDataLabelingServiceDatasetDatasetFormatDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
        [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
        string FormatType
        {
            get;
        }

        /// <summary>text_file_type_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#text_file_type_metadata DataLabelingServiceDataset#text_file_type_metadata}
        /// </remarks>
        [JsiiProperty(name: "textFileTypeMetadata", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata? TextFileTypeMetadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetDatasetFormatDetails), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#format_type DataLabelingServiceDataset#format_type}.</summary>
            [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
            public string FormatType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_file_type_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#text_file_type_metadata DataLabelingServiceDataset#text_file_type_metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "textFileTypeMetadata", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata\"}", isOptional: true)]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata? TextFileTypeMetadata
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata?>();
            }
        }
    }
}
