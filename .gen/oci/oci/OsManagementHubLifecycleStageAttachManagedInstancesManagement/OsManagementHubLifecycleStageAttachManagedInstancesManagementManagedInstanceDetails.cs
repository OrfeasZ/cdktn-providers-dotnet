using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails")]
    public class OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails : oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_attach_managed_instances_management#managed_instances OsManagementHubLifecycleStageAttachManagedInstancesManagement#managed_instances}.</summary>
        [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ManagedInstances
        {
            get;
            set;
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_attach_managed_instances_management#work_request_details OsManagementHubLifecycleStageAttachManagedInstancesManagement#work_request_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubLifecycleStageAttachManagedInstancesManagement.OsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails\"}", isOptional: true)]
        public oci.OsManagementHubLifecycleStageAttachManagedInstancesManagement.IOsManagementHubLifecycleStageAttachManagedInstancesManagementManagedInstanceDetailsWorkRequestDetails? WorkRequestDetails
        {
            get;
            set;
        }
    }
}
