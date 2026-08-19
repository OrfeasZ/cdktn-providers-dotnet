using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataStorageGrid
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudExadataStorageGridTimeouts), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageGrid.DatabaseManagementCloudExadataStorageGridTimeouts")]
    public interface IDatabaseManagementCloudExadataStorageGridTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#create DatabaseManagementCloudExadataStorageGrid#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#delete DatabaseManagementCloudExadataStorageGrid#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#update DatabaseManagementCloudExadataStorageGrid#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudExadataStorageGridTimeouts), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageGrid.DatabaseManagementCloudExadataStorageGridTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudExadataStorageGrid.IDatabaseManagementCloudExadataStorageGridTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#create DatabaseManagementCloudExadataStorageGrid#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#delete DatabaseManagementCloudExadataStorageGrid#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_management_cloud_exadata_storage_grid#update DatabaseManagementCloudExadataStorageGrid#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
