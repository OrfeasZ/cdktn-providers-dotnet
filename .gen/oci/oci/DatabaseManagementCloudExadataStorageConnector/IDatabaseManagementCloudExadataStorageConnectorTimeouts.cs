using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataStorageConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudExadataStorageConnectorTimeouts), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageConnector.DatabaseManagementCloudExadataStorageConnectorTimeouts")]
    public interface IDatabaseManagementCloudExadataStorageConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#create DatabaseManagementCloudExadataStorageConnector#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#delete DatabaseManagementCloudExadataStorageConnector#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#update DatabaseManagementCloudExadataStorageConnector#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudExadataStorageConnectorTimeouts), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageConnector.DatabaseManagementCloudExadataStorageConnectorTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudExadataStorageConnector.IDatabaseManagementCloudExadataStorageConnectorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#create DatabaseManagementCloudExadataStorageConnector#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#delete DatabaseManagementCloudExadataStorageConnector#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#update DatabaseManagementCloudExadataStorageConnector#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
