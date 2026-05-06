using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeDiscoveryJob
{
    [JsiiInterface(nativeType: typeof(IDataSafeDiscoveryJobTablesForDiscovery), fullyQualifiedName: "oci.dataSafeDiscoveryJob.DataSafeDiscoveryJobTablesForDiscovery")]
    public interface IDataSafeDiscoveryJobTablesForDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_discovery_job#schema_name DataSafeDiscoveryJob#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_discovery_job#table_names DataSafeDiscoveryJob#table_names}.</summary>
        [JsiiProperty(name: "tableNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TableNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeDiscoveryJobTablesForDiscovery), fullyQualifiedName: "oci.dataSafeDiscoveryJob.DataSafeDiscoveryJobTablesForDiscovery")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeDiscoveryJob.IDataSafeDiscoveryJobTablesForDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_discovery_job#schema_name DataSafeDiscoveryJob#schema_name}.</summary>
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_discovery_job#table_names DataSafeDiscoveryJob#table_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tableNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TableNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
