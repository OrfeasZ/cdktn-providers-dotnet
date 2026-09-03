using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IOracleCloudVmClusterFileSystemConfiguration), fullyQualifiedName: "azurerm.oracleCloudVmCluster.OracleCloudVmClusterFileSystemConfiguration")]
    public interface IOracleCloudVmClusterFileSystemConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_cloud_vm_cluster#mount_point OracleCloudVmCluster#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_cloud_vm_cluster#size_in_gb OracleCloudVmCluster#size_in_gb}.</summary>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeInGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOracleCloudVmClusterFileSystemConfiguration), fullyQualifiedName: "azurerm.oracleCloudVmCluster.OracleCloudVmClusterFileSystemConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.OracleCloudVmCluster.IOracleCloudVmClusterFileSystemConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_cloud_vm_cluster#mount_point OracleCloudVmCluster#mount_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_cloud_vm_cluster#size_in_gb OracleCloudVmCluster#size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeInGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
