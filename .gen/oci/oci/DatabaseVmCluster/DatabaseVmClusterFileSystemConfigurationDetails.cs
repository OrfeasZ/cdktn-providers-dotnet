using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiByValue(fqn: "oci.databaseVmCluster.DatabaseVmClusterFileSystemConfigurationDetails")]
    public class DatabaseVmClusterFileSystemConfigurationDetails : oci.DatabaseVmCluster.IDatabaseVmClusterFileSystemConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#file_system_size_gb DatabaseVmCluster#file_system_size_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FileSystemSizeGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#mount_point DatabaseVmCluster#mount_point}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPoint
        {
            get;
            set;
        }
    }
}
