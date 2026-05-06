using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudVmClusterFileSystemConfigurationDetails), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetails")]
    public interface IDatabaseCloudVmClusterFileSystemConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#file_system_size_gb DatabaseCloudVmCluster#file_system_size_gb}.</summary>
        [JsiiProperty(name: "fileSystemSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FileSystemSizeGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#mount_point DatabaseCloudVmCluster#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudVmClusterFileSystemConfigurationDetails), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterFileSystemConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#file_system_size_gb DatabaseCloudVmCluster#file_system_size_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FileSystemSizeGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#mount_point DatabaseCloudVmCluster#mount_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPoint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
