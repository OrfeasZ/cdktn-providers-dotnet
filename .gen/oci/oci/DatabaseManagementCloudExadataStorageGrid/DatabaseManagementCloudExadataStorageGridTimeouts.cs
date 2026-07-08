using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataStorageGrid
{
    [JsiiByValue(fqn: "oci.databaseManagementCloudExadataStorageGrid.DatabaseManagementCloudExadataStorageGridTimeouts")]
    public class DatabaseManagementCloudExadataStorageGridTimeouts : oci.DatabaseManagementCloudExadataStorageGrid.IDatabaseManagementCloudExadataStorageGridTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_grid#create DatabaseManagementCloudExadataStorageGrid#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_grid#delete DatabaseManagementCloudExadataStorageGrid#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_grid#update DatabaseManagementCloudExadataStorageGrid#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
