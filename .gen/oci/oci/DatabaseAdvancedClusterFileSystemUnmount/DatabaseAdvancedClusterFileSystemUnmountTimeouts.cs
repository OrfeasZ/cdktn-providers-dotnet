using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAdvancedClusterFileSystemUnmount
{
    [JsiiByValue(fqn: "oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeouts")]
    public class DatabaseAdvancedClusterFileSystemUnmountTimeouts : oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_advanced_cluster_file_system_unmount#create DatabaseAdvancedClusterFileSystemUnmount#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_advanced_cluster_file_system_unmount#delete DatabaseAdvancedClusterFileSystemUnmount#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_advanced_cluster_file_system_unmount#update DatabaseAdvancedClusterFileSystemUnmount#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
