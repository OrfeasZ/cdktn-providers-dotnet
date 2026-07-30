using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleCloudVmCluster
{
    [JsiiByValue(fqn: "azurerm.oracleCloudVmCluster.OracleCloudVmClusterFileSystemConfiguration")]
    public class OracleCloudVmClusterFileSystemConfiguration : azurerm.OracleCloudVmCluster.IOracleCloudVmClusterFileSystemConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/oracle_cloud_vm_cluster#mount_point OracleCloudVmCluster#mount_point}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/oracle_cloud_vm_cluster#size_in_gb OracleCloudVmCluster#size_in_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SizeInGb
        {
            get;
            set;
        }
    }
}
