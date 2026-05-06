using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath")]
    public interface IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#bucket DataLabelingServiceDataset#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#namespace DataLabelingServiceDataset#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#path DataLabelingServiceDataset#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#source_type DataLabelingServiceDataset#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#bucket DataLabelingServiceDataset#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#namespace DataLabelingServiceDataset#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#path DataLabelingServiceDataset#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#source_type DataLabelingServiceDataset#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
