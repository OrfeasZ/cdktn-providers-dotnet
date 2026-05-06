using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestTargets")]
    public class JmsTaskScheduleTaskDetailsCryptoTaskRequestTargets : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequestTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_installation_key JmsTaskSchedule#application_installation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInstallationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInstallationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_key JmsTaskSchedule#application_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#container_key JmsTaskSchedule#container_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jre_key JmsTaskSchedule#jre_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jreKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JreKey
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
