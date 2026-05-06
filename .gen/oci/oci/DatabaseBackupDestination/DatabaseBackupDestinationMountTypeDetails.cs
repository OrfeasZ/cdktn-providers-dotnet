using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseBackupDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseBackupDestination.DatabaseBackupDestinationMountTypeDetails")]
    public class DatabaseBackupDestinationMountTypeDetails : oci.DatabaseBackupDestination.IDatabaseBackupDestinationMountTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#mount_type DatabaseBackupDestination#mount_type}.</summary>
        [JsiiProperty(name: "mountType", typeJson: "{\"primitive\":\"string\"}")]
        public string MountType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#local_mount_point_path DatabaseBackupDestination#local_mount_point_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localMountPointPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalMountPointPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server DatabaseBackupDestination#nfs_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nfsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NfsServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server_export DatabaseBackupDestination#nfs_server_export}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nfsServerExport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NfsServerExport
        {
            get;
            set;
        }
    }
}
