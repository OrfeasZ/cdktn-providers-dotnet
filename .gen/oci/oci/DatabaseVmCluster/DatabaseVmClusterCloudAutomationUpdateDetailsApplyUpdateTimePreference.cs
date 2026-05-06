using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiByValue(fqn: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference")]
    public class DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference : oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#apply_update_preferred_end_time DatabaseVmCluster#apply_update_preferred_end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyUpdatePreferredEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyUpdatePreferredEndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#apply_update_preferred_start_time DatabaseVmCluster#apply_update_preferred_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyUpdatePreferredStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyUpdatePreferredStartTime
        {
            get;
            set;
        }
    }
}
