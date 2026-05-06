using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiByValue(fqn: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod")]
    public class DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod : oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_end_time DatabaseCloudVmCluster#freeze_period_end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FreezePeriodEndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_start_time DatabaseCloudVmCluster#freeze_period_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FreezePeriodStartTime
        {
            get;
            set;
        }
    }
}
