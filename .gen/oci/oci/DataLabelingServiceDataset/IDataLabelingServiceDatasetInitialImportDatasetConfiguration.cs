using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetInitialImportDatasetConfiguration), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration")]
    public interface IDataLabelingServiceDatasetInitialImportDatasetConfiguration
    {
        /// <summary>import_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#import_format DataLabelingServiceDataset#import_format}
        /// </remarks>
        [JsiiProperty(name: "importFormat", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat\"}")]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat ImportFormat
        {
            get;
        }

        /// <summary>import_metadata_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#import_metadata_path DataLabelingServiceDataset#import_metadata_path}
        /// </remarks>
        [JsiiProperty(name: "importMetadataPath", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath\"}")]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath ImportMetadataPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetInitialImportDatasetConfiguration), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>import_format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#import_format DataLabelingServiceDataset#import_format}
            /// </remarks>
            [JsiiProperty(name: "importFormat", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat\"}")]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat ImportFormat
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat>()!;
            }

            /// <summary>import_metadata_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#import_metadata_path DataLabelingServiceDataset#import_metadata_path}
            /// </remarks>
            [JsiiProperty(name: "importMetadataPath", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath\"}")]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath ImportMetadataPath
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath>()!;
            }
        }
    }
}
