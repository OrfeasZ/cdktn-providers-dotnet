using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest")]
    public class JmsTaskScheduleTaskDetailsJfrTaskRequest : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfc_profile_name JmsTaskSchedule#jfc_profile_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jfcProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JfcProfileName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfc_v1 JmsTaskSchedule#jfc_v1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jfcV1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JfcV1
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfc_v2 JmsTaskSchedule#jfc_v2}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jfcV2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JfcV2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#recording_duration_in_minutes JmsTaskSchedule#recording_duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordingDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecordingDurationInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#recording_size_in_mb JmsTaskSchedule#recording_size_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordingSizeInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecordingSizeInMb
        {
            get;
            set;
        }

        private object? _targets;

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#targets JmsTaskSchedule#targets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequestTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Targets
        {
            get => _targets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequestTargets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequestTargets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targets = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#waiting_period_in_minutes JmsTaskSchedule#waiting_period_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitingPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitingPeriodInMinutes
        {
            get;
            set;
        }
    }
}
