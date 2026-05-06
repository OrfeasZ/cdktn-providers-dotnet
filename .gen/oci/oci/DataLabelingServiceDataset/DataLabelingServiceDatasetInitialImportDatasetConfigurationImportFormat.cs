using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat")]
    public class DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat : oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#name DataLabelingServiceDataset#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#version DataLabelingServiceDataset#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
