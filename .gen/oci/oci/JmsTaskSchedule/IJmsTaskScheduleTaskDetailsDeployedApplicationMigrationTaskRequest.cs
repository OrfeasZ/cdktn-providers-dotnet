using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest")]
    public interface IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest
    {
        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/jms_task_schedule#targets JmsTaskSchedule#targets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestTargets" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Targets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/jms_task_schedule#targets JmsTaskSchedule#targets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestTargets" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Targets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
