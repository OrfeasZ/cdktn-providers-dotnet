using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsCryptoTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest")]
    public interface IJmsTaskScheduleTaskDetailsCryptoTaskRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#recording_duration_in_minutes JmsTaskSchedule#recording_duration_in_minutes}.</summary>
        [JsiiProperty(name: "recordingDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecordingDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#targets JmsTaskSchedule#targets}
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Targets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#waiting_period_in_minutes JmsTaskSchedule#waiting_period_in_minutes}.</summary>
        [JsiiProperty(name: "waitingPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitingPeriodInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsCryptoTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#recording_duration_in_minutes JmsTaskSchedule#recording_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordingDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecordingDurationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#targets JmsTaskSchedule#targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequestTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Targets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#waiting_period_in_minutes JmsTaskSchedule#waiting_period_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitingPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitingPeriodInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
