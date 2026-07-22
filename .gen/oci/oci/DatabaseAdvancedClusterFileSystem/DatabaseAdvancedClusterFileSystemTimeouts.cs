using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAdvancedClusterFileSystem
{
    [JsiiByValue(fqn: "oci.databaseAdvancedClusterFileSystem.DatabaseAdvancedClusterFileSystemTimeouts")]
    public class DatabaseAdvancedClusterFileSystemTimeouts : oci.DatabaseAdvancedClusterFileSystem.IDatabaseAdvancedClusterFileSystemTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_advanced_cluster_file_system#create DatabaseAdvancedClusterFileSystem#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_advanced_cluster_file_system#delete DatabaseAdvancedClusterFileSystem#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_advanced_cluster_file_system#update DatabaseAdvancedClusterFileSystem#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
