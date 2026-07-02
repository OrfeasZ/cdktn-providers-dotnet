using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAdvancedClusterFileSystemMount
{
    [JsiiByValue(fqn: "oci.databaseAdvancedClusterFileSystemMount.DatabaseAdvancedClusterFileSystemMountTimeouts")]
    public class DatabaseAdvancedClusterFileSystemMountTimeouts : oci.DatabaseAdvancedClusterFileSystemMount.IDatabaseAdvancedClusterFileSystemMountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_advanced_cluster_file_system_mount#create DatabaseAdvancedClusterFileSystemMount#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_advanced_cluster_file_system_mount#delete DatabaseAdvancedClusterFileSystemMount#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_advanced_cluster_file_system_mount#update DatabaseAdvancedClusterFileSystemMount#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
