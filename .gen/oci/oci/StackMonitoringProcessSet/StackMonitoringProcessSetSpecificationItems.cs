using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringProcessSet
{
    [JsiiByValue(fqn: "oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecificationItems")]
    public class StackMonitoringProcessSetSpecificationItems : oci.StackMonitoringProcessSet.IStackMonitoringProcessSetSpecificationItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#label StackMonitoringProcessSet#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_command StackMonitoringProcessSet#process_command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProcessCommand
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_line_regex_pattern StackMonitoringProcessSet#process_line_regex_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processLineRegexPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProcessLineRegexPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_user StackMonitoringProcessSet#process_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProcessUser
        {
            get;
            set;
        }
    }
}
