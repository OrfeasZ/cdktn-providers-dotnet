using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest")]
    public class JmsTaskScheduleTaskDetailsScanLibraryTaskRequest : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#dynamic_scan_duration_in_minutes JmsTaskSchedule#dynamic_scan_duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicScanDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DynamicScanDurationInMinutes
        {
            get;
            set;
        }

        private object? _isDynamicScan;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#is_dynamic_scan JmsTaskSchedule#is_dynamic_scan}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDynamicScan", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDynamicScan
        {
            get => _isDynamicScan;
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
                _isDynamicScan = value;
            }
        }

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
