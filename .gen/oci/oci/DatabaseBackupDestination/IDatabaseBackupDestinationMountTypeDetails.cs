using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseBackupDestination
{
    [JsiiInterface(nativeType: typeof(IDatabaseBackupDestinationMountTypeDetails), fullyQualifiedName: "oci.databaseBackupDestination.DatabaseBackupDestinationMountTypeDetails")]
    public interface IDatabaseBackupDestinationMountTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#mount_type DatabaseBackupDestination#mount_type}.</summary>
        [JsiiProperty(name: "mountType", typeJson: "{\"primitive\":\"string\"}")]
        string MountType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#local_mount_point_path DatabaseBackupDestination#local_mount_point_path}.</summary>
        [JsiiProperty(name: "localMountPointPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalMountPointPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server DatabaseBackupDestination#nfs_server}.</summary>
        [JsiiProperty(name: "nfsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NfsServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server_export DatabaseBackupDestination#nfs_server_export}.</summary>
        [JsiiProperty(name: "nfsServerExport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NfsServerExport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseBackupDestinationMountTypeDetails), fullyQualifiedName: "oci.databaseBackupDestination.DatabaseBackupDestinationMountTypeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseBackupDestination.IDatabaseBackupDestinationMountTypeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#mount_type DatabaseBackupDestination#mount_type}.</summary>
            [JsiiProperty(name: "mountType", typeJson: "{\"primitive\":\"string\"}")]
            public string MountType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#local_mount_point_path DatabaseBackupDestination#local_mount_point_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localMountPointPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalMountPointPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server DatabaseBackupDestination#nfs_server}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nfsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NfsServer
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_backup_destination#nfs_server_export DatabaseBackupDestination#nfs_server_export}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nfsServerExport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NfsServerExport
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
