using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoringTemplateAlarmCondition
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoringTemplateAlarmCondition.StackMonitoringMonitoringTemplateAlarmConditionTimeouts")]
    public class StackMonitoringMonitoringTemplateAlarmConditionTimeouts : oci.StackMonitoringMonitoringTemplateAlarmCondition.IStackMonitoringMonitoringTemplateAlarmConditionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#create StackMonitoringMonitoringTemplateAlarmCondition#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#delete StackMonitoringMonitoringTemplateAlarmCondition#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#update StackMonitoringMonitoringTemplateAlarmCondition#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
