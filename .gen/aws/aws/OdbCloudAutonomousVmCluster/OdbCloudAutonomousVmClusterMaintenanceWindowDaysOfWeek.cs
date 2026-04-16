using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudAutonomousVmCluster
{
    [JsiiByValue(fqn: "aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek")]
    public class OdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek : aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_autonomous_vm_cluster#name OdbCloudAutonomousVmCluster#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
