using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSensitiveDataModel.DataSafeSensitiveDataModelTablesForDiscovery")]
    public class DataSafeSensitiveDataModelTablesForDiscovery : oci.DataSafeSensitiveDataModel.IDataSafeSensitiveDataModelTablesForDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#schema_name DataSafeSensitiveDataModel#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public string SchemaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#table_names DataSafeSensitiveDataModel#table_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TableNames
        {
            get;
            set;
        }
    }
}
