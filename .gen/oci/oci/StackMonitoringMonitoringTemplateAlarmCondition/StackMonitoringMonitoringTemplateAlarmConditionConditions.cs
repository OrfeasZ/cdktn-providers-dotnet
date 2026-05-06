using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoringTemplateAlarmCondition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMonitoringTemplateAlarmCondition.StackMonitoringMonitoringTemplateAlarmConditionConditions")]
    public class StackMonitoringMonitoringTemplateAlarmConditionConditions : oci.StackMonitoringMonitoringTemplateAlarmCondition.IStackMonitoringMonitoringTemplateAlarmConditionConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#query StackMonitoringMonitoringTemplateAlarmCondition#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#severity StackMonitoringMonitoringTemplateAlarmCondition#severity}.</summary>
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public string Severity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#body StackMonitoringMonitoringTemplateAlarmCondition#body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Body
        {
            get;
            set;
        }

        private object? _shouldAppendNote;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_note StackMonitoringMonitoringTemplateAlarmCondition#should_append_note}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldAppendNote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldAppendNote
        {
            get => _shouldAppendNote;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldAppendNote = value;
            }
        }

        private object? _shouldAppendUrl;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_url StackMonitoringMonitoringTemplateAlarmCondition#should_append_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldAppendUrl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldAppendUrl
        {
            get => _shouldAppendUrl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldAppendUrl = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#trigger_delay StackMonitoringMonitoringTemplateAlarmCondition#trigger_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TriggerDelay
        {
            get;
            set;
        }
    }
}
