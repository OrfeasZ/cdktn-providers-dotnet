using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModel
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveDataModelTablesForDiscovery), fullyQualifiedName: "oci.dataSafeSensitiveDataModel.DataSafeSensitiveDataModelTablesForDiscovery")]
    public interface IDataSafeSensitiveDataModelTablesForDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#schema_name DataSafeSensitiveDataModel#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#table_names DataSafeSensitiveDataModel#table_names}.</summary>
        [JsiiProperty(name: "tableNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TableNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveDataModelTablesForDiscovery), fullyQualifiedName: "oci.dataSafeSensitiveDataModel.DataSafeSensitiveDataModelTablesForDiscovery")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveDataModel.IDataSafeSensitiveDataModelTablesForDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#schema_name DataSafeSensitiveDataModel#schema_name}.</summary>
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model#table_names DataSafeSensitiveDataModel#table_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tableNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TableNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
