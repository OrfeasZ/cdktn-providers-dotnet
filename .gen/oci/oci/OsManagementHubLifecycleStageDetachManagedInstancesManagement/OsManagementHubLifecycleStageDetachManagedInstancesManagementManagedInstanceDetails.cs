using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails")]
    public class OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails : oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#managed_instances OsManagementHubLifecycleStageDetachManagedInstancesManagement#managed_instances}.</summary>
        [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ManagedInstances
        {
            get;
            set;
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#work_request_details OsManagementHubLifecycleStageDetachManagedInstancesManagement#work_request_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails\"}", isOptional: true)]
        public oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails? WorkRequestDetails
        {
            get;
            set;
        }
    }
}
