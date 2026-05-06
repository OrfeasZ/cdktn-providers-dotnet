using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest")]
    public class JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_ids JmsTaskSchedule#managed_instance_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ManagedInstanceIds
        {
            get;
            set;
        }
    }
}
