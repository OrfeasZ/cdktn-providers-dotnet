using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites")]
    public class JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_key JmsTaskSchedule#installation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "installationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstallationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedInstanceId
        {
            get;
            set;
        }
    }
}
