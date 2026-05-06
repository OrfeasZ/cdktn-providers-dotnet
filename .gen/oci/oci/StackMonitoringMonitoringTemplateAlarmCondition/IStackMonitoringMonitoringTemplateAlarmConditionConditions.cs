using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoringTemplateAlarmCondition
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoringTemplateAlarmConditionConditions), fullyQualifiedName: "oci.stackMonitoringMonitoringTemplateAlarmCondition.StackMonitoringMonitoringTemplateAlarmConditionConditions")]
    public interface IStackMonitoringMonitoringTemplateAlarmConditionConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#query StackMonitoringMonitoringTemplateAlarmCondition#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#severity StackMonitoringMonitoringTemplateAlarmCondition#severity}.</summary>
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        string Severity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#body StackMonitoringMonitoringTemplateAlarmCondition#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_note StackMonitoringMonitoringTemplateAlarmCondition#should_append_note}.</summary>
        [JsiiProperty(name: "shouldAppendNote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldAppendNote
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_url StackMonitoringMonitoringTemplateAlarmCondition#should_append_url}.</summary>
        [JsiiProperty(name: "shouldAppendUrl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldAppendUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#trigger_delay StackMonitoringMonitoringTemplateAlarmCondition#trigger_delay}.</summary>
        [JsiiProperty(name: "triggerDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TriggerDelay
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoringTemplateAlarmConditionConditions), fullyQualifiedName: "oci.stackMonitoringMonitoringTemplateAlarmCondition.StackMonitoringMonitoringTemplateAlarmConditionConditions")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoringTemplateAlarmCondition.IStackMonitoringMonitoringTemplateAlarmConditionConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#query StackMonitoringMonitoringTemplateAlarmCondition#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#severity StackMonitoringMonitoringTemplateAlarmCondition#severity}.</summary>
            [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
            public string Severity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#body StackMonitoringMonitoringTemplateAlarmCondition#body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Body
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_note StackMonitoringMonitoringTemplateAlarmCondition#should_append_note}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldAppendNote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldAppendNote
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#should_append_url StackMonitoringMonitoringTemplateAlarmCondition#should_append_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldAppendUrl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldAppendUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_alarm_condition#trigger_delay StackMonitoringMonitoringTemplateAlarmCondition#trigger_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TriggerDelay
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
