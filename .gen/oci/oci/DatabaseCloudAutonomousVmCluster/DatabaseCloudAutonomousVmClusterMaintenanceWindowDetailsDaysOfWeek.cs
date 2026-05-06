using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudAutonomousVmCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek")]
    public class DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek : oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#name DatabaseCloudAutonomousVmCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
